// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnForceFinishScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnForceFinishScNotify.proto</summary>
  public static partial class PlayerReturnForceFinishScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnForceFinishScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnForceFinishScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQbGF5ZXJSZXR1cm5Gb3JjZUZpbmlzaFNjTm90aWZ5LnByb3RvGhFLTUJJ",
            "Q0pIQ1BGSy5wcm90byJECh9QbGF5ZXJSZXR1cm5Gb3JjZUZpbmlzaFNjTm90",
            "aWZ5EiEKC0VETE5CT0FLQUdOGAggASgLMgwuS01CSUNKSENQRktCHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KMBICJHCPFKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnForceFinishScNotify), global::EggLink.DanhengServer.Proto.PlayerReturnForceFinishScNotify.Parser, new[]{ "EDLNBOAKAGN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnForceFinishScNotify : pb::IMessage<PlayerReturnForceFinishScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnForceFinishScNotify> _parser = new pb::MessageParser<PlayerReturnForceFinishScNotify>(() => new PlayerReturnForceFinishScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnForceFinishScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnForceFinishScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnForceFinishScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnForceFinishScNotify(PlayerReturnForceFinishScNotify other) : this() {
      eDLNBOAKAGN_ = other.eDLNBOAKAGN_ != null ? other.eDLNBOAKAGN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnForceFinishScNotify Clone() {
      return new PlayerReturnForceFinishScNotify(this);
    }

    /// <summary>Field number for the "EDLNBOAKAGN" field.</summary>
    public const int EDLNBOAKAGNFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.KMBICJHCPFK eDLNBOAKAGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KMBICJHCPFK EDLNBOAKAGN {
      get { return eDLNBOAKAGN_; }
      set {
        eDLNBOAKAGN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnForceFinishScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnForceFinishScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EDLNBOAKAGN, other.EDLNBOAKAGN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eDLNBOAKAGN_ != null) hash ^= EDLNBOAKAGN.GetHashCode();
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
      if (eDLNBOAKAGN_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EDLNBOAKAGN);
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
      if (eDLNBOAKAGN_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EDLNBOAKAGN);
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
      if (eDLNBOAKAGN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EDLNBOAKAGN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnForceFinishScNotify other) {
      if (other == null) {
        return;
      }
      if (other.eDLNBOAKAGN_ != null) {
        if (eDLNBOAKAGN_ == null) {
          EDLNBOAKAGN = new global::EggLink.DanhengServer.Proto.KMBICJHCPFK();
        }
        EDLNBOAKAGN.MergeFrom(other.EDLNBOAKAGN);
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
            if (eDLNBOAKAGN_ == null) {
              EDLNBOAKAGN = new global::EggLink.DanhengServer.Proto.KMBICJHCPFK();
            }
            input.ReadMessage(EDLNBOAKAGN);
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
            if (eDLNBOAKAGN_ == null) {
              EDLNBOAKAGN = new global::EggLink.DanhengServer.Proto.KMBICJHCPFK();
            }
            input.ReadMessage(EDLNBOAKAGN);
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