// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetVideoVersionKeyScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetVideoVersionKeyScRsp.proto</summary>
  public static partial class GetVideoVersionKeyScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetVideoVersionKeyScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetVideoVersionKeyScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRWaWRlb1ZlcnNpb25LZXlTY1JzcC5wcm90bxoSVmlkZW9LZXlJbmZv",
            "LnByb3RvIosBChdHZXRWaWRlb1ZlcnNpb25LZXlTY1JzcBIqChN2aWRlb19r",
            "ZXlfaW5mb19saXN0GAogAygLMg0uVmlkZW9LZXlJbmZvEjMKHGFjdGl2aXR5",
            "X3ZpZGVvX2tleV9pbmZvX2xpc3QYAyADKAsyDS5WaWRlb0tleUluZm8SDwoH",
            "cmV0Y29kZRgGIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.VideoKeyInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetVideoVersionKeyScRsp), global::EggLink.DanhengServer.Proto.GetVideoVersionKeyScRsp.Parser, new[]{ "VideoKeyInfoList", "ActivityVideoKeyInfoList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetVideoVersionKeyScRsp : pb::IMessage<GetVideoVersionKeyScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetVideoVersionKeyScRsp> _parser = new pb::MessageParser<GetVideoVersionKeyScRsp>(() => new GetVideoVersionKeyScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetVideoVersionKeyScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetVideoVersionKeyScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetVideoVersionKeyScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetVideoVersionKeyScRsp(GetVideoVersionKeyScRsp other) : this() {
      videoKeyInfoList_ = other.videoKeyInfoList_.Clone();
      activityVideoKeyInfoList_ = other.activityVideoKeyInfoList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetVideoVersionKeyScRsp Clone() {
      return new GetVideoVersionKeyScRsp(this);
    }

    /// <summary>Field number for the "video_key_info_list" field.</summary>
    public const int VideoKeyInfoListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.VideoKeyInfo> _repeated_videoKeyInfoList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.VideoKeyInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.VideoKeyInfo> videoKeyInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.VideoKeyInfo>();
    /// <summary>
    /// 3
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.VideoKeyInfo> VideoKeyInfoList {
      get { return videoKeyInfoList_; }
    }

    /// <summary>Field number for the "activity_video_key_info_list" field.</summary>
    public const int ActivityVideoKeyInfoListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.VideoKeyInfo> _repeated_activityVideoKeyInfoList_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.VideoKeyInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.VideoKeyInfo> activityVideoKeyInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.VideoKeyInfo>();
    /// <summary>
    /// 10
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.VideoKeyInfo> ActivityVideoKeyInfoList {
      get { return activityVideoKeyInfoList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
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
      return Equals(other as GetVideoVersionKeyScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetVideoVersionKeyScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!videoKeyInfoList_.Equals(other.videoKeyInfoList_)) return false;
      if(!activityVideoKeyInfoList_.Equals(other.activityVideoKeyInfoList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= videoKeyInfoList_.GetHashCode();
      hash ^= activityVideoKeyInfoList_.GetHashCode();
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
      activityVideoKeyInfoList_.WriteTo(output, _repeated_activityVideoKeyInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      videoKeyInfoList_.WriteTo(output, _repeated_videoKeyInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      activityVideoKeyInfoList_.WriteTo(ref output, _repeated_activityVideoKeyInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      videoKeyInfoList_.WriteTo(ref output, _repeated_videoKeyInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += videoKeyInfoList_.CalculateSize(_repeated_videoKeyInfoList_codec);
      size += activityVideoKeyInfoList_.CalculateSize(_repeated_activityVideoKeyInfoList_codec);
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
    public void MergeFrom(GetVideoVersionKeyScRsp other) {
      if (other == null) {
        return;
      }
      videoKeyInfoList_.Add(other.videoKeyInfoList_);
      activityVideoKeyInfoList_.Add(other.activityVideoKeyInfoList_);
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
          case 26: {
            activityVideoKeyInfoList_.AddEntriesFrom(input, _repeated_activityVideoKeyInfoList_codec);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            videoKeyInfoList_.AddEntriesFrom(input, _repeated_videoKeyInfoList_codec);
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
            activityVideoKeyInfoList_.AddEntriesFrom(ref input, _repeated_activityVideoKeyInfoList_codec);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            videoKeyInfoList_.AddEntriesFrom(ref input, _repeated_videoKeyInfoList_codec);
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
