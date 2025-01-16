// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournDoorInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournDoorInfo.proto</summary>
  public static partial class RogueTournDoorInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournDoorInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournDoorInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZVRvdXJuRG9vckluZm8ucHJvdG8iZgoSUm9ndWVUb3VybkRvb3JJ",
            "bmZvEhgKEGVudGVyX25leHRfbGF5ZXIYBiABKAgSEwoLSkhHTkNJQk9QQkUY",
            "AiABKA0SIQoZcm9ndWVfZG9vcl9uZXh0X3Jvb21fdHlwZRgOIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournDoorInfo), global::EggLink.DanhengServer.Proto.RogueTournDoorInfo.Parser, new[]{ "EnterNextLayer", "JHGNCIBOPBE", "RogueDoorNextRoomType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournDoorInfo : pb::IMessage<RogueTournDoorInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournDoorInfo> _parser = new pb::MessageParser<RogueTournDoorInfo>(() => new RogueTournDoorInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournDoorInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournDoorInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournDoorInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournDoorInfo(RogueTournDoorInfo other) : this() {
      enterNextLayer_ = other.enterNextLayer_;
      jHGNCIBOPBE_ = other.jHGNCIBOPBE_;
      rogueDoorNextRoomType_ = other.rogueDoorNextRoomType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournDoorInfo Clone() {
      return new RogueTournDoorInfo(this);
    }

    /// <summary>Field number for the "enter_next_layer" field.</summary>
    public const int EnterNextLayerFieldNumber = 6;
    private bool enterNextLayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnterNextLayer {
      get { return enterNextLayer_; }
      set {
        enterNextLayer_ = value;
      }
    }

    /// <summary>Field number for the "JHGNCIBOPBE" field.</summary>
    public const int JHGNCIBOPBEFieldNumber = 2;
    private uint jHGNCIBOPBE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JHGNCIBOPBE {
      get { return jHGNCIBOPBE_; }
      set {
        jHGNCIBOPBE_ = value;
      }
    }

    /// <summary>Field number for the "rogue_door_next_room_type" field.</summary>
    public const int RogueDoorNextRoomTypeFieldNumber = 14;
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
      return Equals(other as RogueTournDoorInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournDoorInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnterNextLayer != other.EnterNextLayer) return false;
      if (JHGNCIBOPBE != other.JHGNCIBOPBE) return false;
      if (RogueDoorNextRoomType != other.RogueDoorNextRoomType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EnterNextLayer != false) hash ^= EnterNextLayer.GetHashCode();
      if (JHGNCIBOPBE != 0) hash ^= JHGNCIBOPBE.GetHashCode();
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
      if (JHGNCIBOPBE != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JHGNCIBOPBE);
      }
      if (EnterNextLayer != false) {
        output.WriteRawTag(48);
        output.WriteBool(EnterNextLayer);
      }
      if (RogueDoorNextRoomType != 0) {
        output.WriteRawTag(112);
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
      if (JHGNCIBOPBE != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JHGNCIBOPBE);
      }
      if (EnterNextLayer != false) {
        output.WriteRawTag(48);
        output.WriteBool(EnterNextLayer);
      }
      if (RogueDoorNextRoomType != 0) {
        output.WriteRawTag(112);
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
      if (EnterNextLayer != false) {
        size += 1 + 1;
      }
      if (JHGNCIBOPBE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JHGNCIBOPBE);
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
    public void MergeFrom(RogueTournDoorInfo other) {
      if (other == null) {
        return;
      }
      if (other.EnterNextLayer != false) {
        EnterNextLayer = other.EnterNextLayer;
      }
      if (other.JHGNCIBOPBE != 0) {
        JHGNCIBOPBE = other.JHGNCIBOPBE;
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
          case 16: {
            JHGNCIBOPBE = input.ReadUInt32();
            break;
          }
          case 48: {
            EnterNextLayer = input.ReadBool();
            break;
          }
          case 112: {
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
          case 16: {
            JHGNCIBOPBE = input.ReadUInt32();
            break;
          }
          case 48: {
            EnterNextLayer = input.ReadBool();
            break;
          }
          case 112: {
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
