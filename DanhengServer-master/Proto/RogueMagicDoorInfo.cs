// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMagicDoorInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMagicDoorInfo.proto</summary>
  public static partial class RogueMagicDoorInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMagicDoorInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMagicDoorInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZU1hZ2ljRG9vckluZm8ucHJvdG8iZgoSUm9ndWVNYWdpY0Rvb3JJ",
            "bmZvEhMKC0pIR05DSUJPUEJFGAggASgNEhgKEGVudGVyX25leHRfbGF5ZXIY",
            "ASABKAgSIQoZcm9ndWVfZG9vcl9uZXh0X3Jvb21fdHlwZRgPIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo), global::EggLink.DanhengServer.Proto.RogueMagicDoorInfo.Parser, new[]{ "JHGNCIBOPBE", "EnterNextLayer", "RogueDoorNextRoomType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMagicDoorInfo : pb::IMessage<RogueMagicDoorInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMagicDoorInfo> _parser = new pb::MessageParser<RogueMagicDoorInfo>(() => new RogueMagicDoorInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMagicDoorInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMagicDoorInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicDoorInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicDoorInfo(RogueMagicDoorInfo other) : this() {
      jHGNCIBOPBE_ = other.jHGNCIBOPBE_;
      enterNextLayer_ = other.enterNextLayer_;
      rogueDoorNextRoomType_ = other.rogueDoorNextRoomType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicDoorInfo Clone() {
      return new RogueMagicDoorInfo(this);
    }

    /// <summary>Field number for the "JHGNCIBOPBE" field.</summary>
    public const int JHGNCIBOPBEFieldNumber = 8;
    private uint jHGNCIBOPBE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JHGNCIBOPBE {
      get { return jHGNCIBOPBE_; }
      set {
        jHGNCIBOPBE_ = value;
      }
    }

    /// <summary>Field number for the "enter_next_layer" field.</summary>
    public const int EnterNextLayerFieldNumber = 1;
    private bool enterNextLayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnterNextLayer {
      get { return enterNextLayer_; }
      set {
        enterNextLayer_ = value;
      }
    }

    /// <summary>Field number for the "rogue_door_next_room_type" field.</summary>
    public const int RogueDoorNextRoomTypeFieldNumber = 15;
    private uint rogueDoorNextRoomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueDoorNextRoomType {
      get { return rogueDoorNextRoomType_; }
      set {
        rogueDoorNextRoomType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMagicDoorInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMagicDoorInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JHGNCIBOPBE != other.JHGNCIBOPBE) return false;
      if (EnterNextLayer != other.EnterNextLayer) return false;
      if (RogueDoorNextRoomType != other.RogueDoorNextRoomType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JHGNCIBOPBE != 0) hash ^= JHGNCIBOPBE.GetHashCode();
      if (EnterNextLayer != false) hash ^= EnterNextLayer.GetHashCode();
      if (RogueDoorNextRoomType != 0) hash ^= RogueDoorNextRoomType.GetHashCode();
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
      if (EnterNextLayer != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnterNextLayer);
      }
      if (JHGNCIBOPBE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JHGNCIBOPBE);
      }
      if (RogueDoorNextRoomType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RogueDoorNextRoomType);
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
      if (EnterNextLayer != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnterNextLayer);
      }
      if (JHGNCIBOPBE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(JHGNCIBOPBE);
      }
      if (RogueDoorNextRoomType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RogueDoorNextRoomType);
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
      if (JHGNCIBOPBE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JHGNCIBOPBE);
      }
      if (EnterNextLayer != false) {
        size += 1 + 1;
      }
      if (RogueDoorNextRoomType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueDoorNextRoomType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMagicDoorInfo other) {
      if (other == null) {
        return;
      }
      if (other.JHGNCIBOPBE != 0) {
        JHGNCIBOPBE = other.JHGNCIBOPBE;
      }
      if (other.EnterNextLayer != false) {
        EnterNextLayer = other.EnterNextLayer;
      }
      if (other.RogueDoorNextRoomType != 0) {
        RogueDoorNextRoomType = other.RogueDoorNextRoomType;
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
            EnterNextLayer = input.ReadBool();
            break;
          }
          case 64: {
            JHGNCIBOPBE = input.ReadUInt32();
            break;
          }
          case 120: {
            RogueDoorNextRoomType = input.ReadUInt32();
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
            EnterNextLayer = input.ReadBool();
            break;
          }
          case 64: {
            JHGNCIBOPBE = input.ReadUInt32();
            break;
          }
          case 120: {
            RogueDoorNextRoomType = input.ReadUInt32();
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
