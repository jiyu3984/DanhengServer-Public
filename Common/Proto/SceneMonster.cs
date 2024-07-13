// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneMonster.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneMonster.proto</summary>
  public static partial class SceneMonsterReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneMonster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneMonsterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTY2VuZU1vbnN0ZXIucHJvdG8iQgoMU2NlbmVNb25zdGVyEhIKCm1vbnN0",
            "ZXJfaWQYAiABKA0SDgoGbWF4X3NwGAkgASgNEg4KBmN1cl9zcBgDIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneMonster), global::EggLink.DanhengServer.Proto.SceneMonster.Parser, new[]{ "MonsterId", "MaxSp", "CurSp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneMonster : pb::IMessage<SceneMonster>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneMonster> _parser = new pb::MessageParser<SceneMonster>(() => new SceneMonster());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneMonster> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneMonsterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonster() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonster(SceneMonster other) : this() {
      monsterId_ = other.monsterId_;
      maxSp_ = other.maxSp_;
      curSp_ = other.curSp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonster Clone() {
      return new SceneMonster(this);
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 2;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "max_sp" field.</summary>
    public const int MaxSpFieldNumber = 9;
    private uint maxSp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxSp {
      get { return maxSp_; }
      set {
        maxSp_ = value;
      }
    }

    /// <summary>Field number for the "cur_sp" field.</summary>
    public const int CurSpFieldNumber = 3;
    private uint curSp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSp {
      get { return curSp_; }
      set {
        curSp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneMonster);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneMonster other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonsterId != other.MonsterId) return false;
      if (MaxSp != other.MaxSp) return false;
      if (CurSp != other.CurSp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (MaxSp != 0) hash ^= MaxSp.GetHashCode();
      if (CurSp != 0) hash ^= CurSp.GetHashCode();
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
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      if (CurSp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurSp);
      }
      if (MaxSp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxSp);
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
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      if (CurSp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurSp);
      }
      if (MaxSp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxSp);
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
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (MaxSp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxSp);
      }
      if (CurSp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneMonster other) {
      if (other == null) {
        return;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.MaxSp != 0) {
        MaxSp = other.MaxSp;
      }
      if (other.CurSp != 0) {
        CurSp = other.CurSp;
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
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            CurSp = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxSp = input.ReadUInt32();
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
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            CurSp = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxSp = input.ReadUInt32();
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