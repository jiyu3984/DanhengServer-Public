// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MakeMissionDrinkScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MakeMissionDrinkScRsp.proto</summary>
  public static partial class MakeMissionDrinkScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MakeMissionDrinkScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MakeMissionDrinkScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNYWtlTWlzc2lvbkRyaW5rU2NSc3AucHJvdG8aEUhISUlOQkVQQ1BJLnBy",
            "b3RvIm4KFU1ha2VNaXNzaW9uRHJpbmtTY1JzcBIPCgdyZXRjb2RlGAkgASgN",
            "Eg8KB2lzX3N1Y2MYBiABKAgSDwoHaXNfc2F2ZRgKIAEoCBIiCgxjdXN0b21f",
            "ZHJpbmsYASABKAsyDC5ISElJTkJFUENQSUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HHIINBEPCPIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MakeMissionDrinkScRsp), global::EggLink.DanhengServer.Proto.MakeMissionDrinkScRsp.Parser, new[]{ "Retcode", "IsSucc", "IsSave", "CustomDrink" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MakeMissionDrinkScRsp : pb::IMessage<MakeMissionDrinkScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MakeMissionDrinkScRsp> _parser = new pb::MessageParser<MakeMissionDrinkScRsp>(() => new MakeMissionDrinkScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MakeMissionDrinkScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MakeMissionDrinkScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MakeMissionDrinkScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MakeMissionDrinkScRsp(MakeMissionDrinkScRsp other) : this() {
      retcode_ = other.retcode_;
      isSucc_ = other.isSucc_;
      isSave_ = other.isSave_;
      customDrink_ = other.customDrink_ != null ? other.customDrink_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MakeMissionDrinkScRsp Clone() {
      return new MakeMissionDrinkScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "is_succ" field.</summary>
    public const int IsSuccFieldNumber = 6;
    private bool isSucc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSucc {
      get { return isSucc_; }
      set {
        isSucc_ = value;
      }
    }

    /// <summary>Field number for the "is_save" field.</summary>
    public const int IsSaveFieldNumber = 10;
    private bool isSave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSave {
      get { return isSave_; }
      set {
        isSave_ = value;
      }
    }

    /// <summary>Field number for the "custom_drink" field.</summary>
    public const int CustomDrinkFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.HHIINBEPCPI customDrink_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HHIINBEPCPI CustomDrink {
      get { return customDrink_; }
      set {
        customDrink_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MakeMissionDrinkScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MakeMissionDrinkScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (IsSucc != other.IsSucc) return false;
      if (IsSave != other.IsSave) return false;
      if (!object.Equals(CustomDrink, other.CustomDrink)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (IsSucc != false) hash ^= IsSucc.GetHashCode();
      if (IsSave != false) hash ^= IsSave.GetHashCode();
      if (customDrink_ != null) hash ^= CustomDrink.GetHashCode();
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
      if (customDrink_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CustomDrink);
      }
      if (IsSucc != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsSucc);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (IsSave != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSave);
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
      if (customDrink_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CustomDrink);
      }
      if (IsSucc != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsSucc);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (IsSave != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSave);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (IsSucc != false) {
        size += 1 + 1;
      }
      if (IsSave != false) {
        size += 1 + 1;
      }
      if (customDrink_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomDrink);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MakeMissionDrinkScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.IsSucc != false) {
        IsSucc = other.IsSucc;
      }
      if (other.IsSave != false) {
        IsSave = other.IsSave;
      }
      if (other.customDrink_ != null) {
        if (customDrink_ == null) {
          CustomDrink = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
        }
        CustomDrink.MergeFrom(other.CustomDrink);
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
          case 10: {
            if (customDrink_ == null) {
              CustomDrink = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
            }
            input.ReadMessage(CustomDrink);
            break;
          }
          case 48: {
            IsSucc = input.ReadBool();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            IsSave = input.ReadBool();
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
          case 10: {
            if (customDrink_ == null) {
              CustomDrink = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
            }
            input.ReadMessage(CustomDrink);
            break;
          }
          case 48: {
            IsSucc = input.ReadBool();
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            IsSave = input.ReadBool();
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
