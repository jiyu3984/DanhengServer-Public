// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureSelectMessageScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureSelectMessageScRsp.proto</summary>
  public static partial class TravelBrochureSelectMessageScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureSelectMessageScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureSelectMessageScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZUcmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VTY1JzcC5wcm90bxoOSXRl",
            "bUxpc3QucHJvdG8aEUJDRU5OQUxGQ0NPLnByb3RvInEKIFRyYXZlbEJyb2No",
            "dXJlU2VsZWN0TWVzc2FnZVNjUnNwEhkKBnJld2FyZBgJIAEoCzIJLkl0ZW1M",
            "aXN0Eg8KB3JldGNvZGUYDyABKA0SIQoLR0NDRkNKSUtPTE0YBSABKAsyDC5C",
            "Q0VOTkFMRkNDT0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.BCENNALFCCOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureSelectMessageScRsp), global::EggLink.DanhengServer.Proto.TravelBrochureSelectMessageScRsp.Parser, new[]{ "Reward", "Retcode", "GCCFCJIKOLM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureSelectMessageScRsp : pb::IMessage<TravelBrochureSelectMessageScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureSelectMessageScRsp> _parser = new pb::MessageParser<TravelBrochureSelectMessageScRsp>(() => new TravelBrochureSelectMessageScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureSelectMessageScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureSelectMessageScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureSelectMessageScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureSelectMessageScRsp(TravelBrochureSelectMessageScRsp other) : this() {
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      retcode_ = other.retcode_;
      gCCFCJIKOLM_ = other.gCCFCJIKOLM_ != null ? other.gCCFCJIKOLM_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureSelectMessageScRsp Clone() {
      return new TravelBrochureSelectMessageScRsp(this);
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GCCFCJIKOLM" field.</summary>
    public const int GCCFCJIKOLMFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.BCENNALFCCO gCCFCJIKOLM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BCENNALFCCO GCCFCJIKOLM {
      get { return gCCFCJIKOLM_; }
      set {
        gCCFCJIKOLM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TravelBrochureSelectMessageScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureSelectMessageScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reward, other.Reward)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(GCCFCJIKOLM, other.GCCFCJIKOLM)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (gCCFCJIKOLM_ != null) hash ^= GCCFCJIKOLM.GetHashCode();
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
      if (gCCFCJIKOLM_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GCCFCJIKOLM);
      }
      if (reward_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Reward);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      if (gCCFCJIKOLM_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GCCFCJIKOLM);
      }
      if (reward_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Reward);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Retcode);
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
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (gCCFCJIKOLM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GCCFCJIKOLM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TravelBrochureSelectMessageScRsp other) {
      if (other == null) {
        return;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.gCCFCJIKOLM_ != null) {
        if (gCCFCJIKOLM_ == null) {
          GCCFCJIKOLM = new global::EggLink.DanhengServer.Proto.BCENNALFCCO();
        }
        GCCFCJIKOLM.MergeFrom(other.GCCFCJIKOLM);
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
            if (gCCFCJIKOLM_ == null) {
              GCCFCJIKOLM = new global::EggLink.DanhengServer.Proto.BCENNALFCCO();
            }
            input.ReadMessage(GCCFCJIKOLM);
            break;
          }
          case 74: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
            if (gCCFCJIKOLM_ == null) {
              GCCFCJIKOLM = new global::EggLink.DanhengServer.Proto.BCENNALFCCO();
            }
            input.ReadMessage(GCCFCJIKOLM);
            break;
          }
          case 74: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 120: {
            Retcode = input.ReadUInt32();
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
