// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DrinkMakerGuest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DrinkMakerGuest.proto</summary>
  public static partial class DrinkMakerGuestReflection {

    #region Descriptor
    /// <summary>File descriptor for DrinkMakerGuest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DrinkMakerGuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVEcmlua01ha2VyR3Vlc3QucHJvdG8iUwoPRHJpbmtNYWtlckd1ZXN0Eh8K",
            "F3VubG9ja2VkX2Zhdm9yX3RhZ19saXN0GAggAygNEg0KBWZhaXRoGAQgASgN",
            "EhAKCGd1ZXN0X2lkGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DrinkMakerGuest), global::EggLink.DanhengServer.Proto.DrinkMakerGuest.Parser, new[]{ "UnlockedFavorTagList", "Faith", "GuestId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DrinkMakerGuest : pb::IMessage<DrinkMakerGuest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DrinkMakerGuest> _parser = new pb::MessageParser<DrinkMakerGuest>(() => new DrinkMakerGuest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DrinkMakerGuest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DrinkMakerGuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrinkMakerGuest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrinkMakerGuest(DrinkMakerGuest other) : this() {
      unlockedFavorTagList_ = other.unlockedFavorTagList_.Clone();
      faith_ = other.faith_;
      guestId_ = other.guestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrinkMakerGuest Clone() {
      return new DrinkMakerGuest(this);
    }

    /// <summary>Field number for the "unlocked_favor_tag_list" field.</summary>
    public const int UnlockedFavorTagListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedFavorTagList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> unlockedFavorTagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedFavorTagList {
      get { return unlockedFavorTagList_; }
    }

    /// <summary>Field number for the "faith" field.</summary>
    public const int FaithFieldNumber = 4;
    private uint faith_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Faith {
      get { return faith_; }
      set {
        faith_ = value;
      }
    }

    /// <summary>Field number for the "guest_id" field.</summary>
    public const int GuestIdFieldNumber = 1;
    private uint guestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GuestId {
      get { return guestId_; }
      set {
        guestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DrinkMakerGuest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DrinkMakerGuest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockedFavorTagList_.Equals(other.unlockedFavorTagList_)) return false;
      if (Faith != other.Faith) return false;
      if (GuestId != other.GuestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockedFavorTagList_.GetHashCode();
      if (Faith != 0) hash ^= Faith.GetHashCode();
      if (GuestId != 0) hash ^= GuestId.GetHashCode();
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
      if (GuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GuestId);
      }
      if (Faith != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Faith);
      }
      unlockedFavorTagList_.WriteTo(output, _repeated_unlockedFavorTagList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GuestId);
      }
      if (Faith != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Faith);
      }
      unlockedFavorTagList_.WriteTo(ref output, _repeated_unlockedFavorTagList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unlockedFavorTagList_.CalculateSize(_repeated_unlockedFavorTagList_codec);
      if (Faith != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Faith);
      }
      if (GuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GuestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DrinkMakerGuest other) {
      if (other == null) {
        return;
      }
      unlockedFavorTagList_.Add(other.unlockedFavorTagList_);
      if (other.Faith != 0) {
        Faith = other.Faith;
      }
      if (other.GuestId != 0) {
        GuestId = other.GuestId;
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
            GuestId = input.ReadUInt32();
            break;
          }
          case 32: {
            Faith = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            unlockedFavorTagList_.AddEntriesFrom(input, _repeated_unlockedFavorTagList_codec);
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
            GuestId = input.ReadUInt32();
            break;
          }
          case 32: {
            Faith = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            unlockedFavorTagList_.AddEntriesFrom(ref input, _repeated_unlockedFavorTagList_codec);
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