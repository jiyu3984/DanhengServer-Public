// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: APOIBBGLIPM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from APOIBBGLIPM.proto</summary>
  public static partial class APOIBBGLIPMReflection {

    #region Descriptor
    /// <summary>File descriptor for APOIBBGLIPM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static APOIBBGLIPMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBUE9JQkJHTElQTS5wcm90bxoRTE1GUEJCR05MSU8ucHJvdG8aEUxBSU5B",
            "SUtMS0NCLnByb3RvGhZCYXR0bGVSZWNvcmRUeXBlLnByb3RvInwKC0FQT0lC",
            "QkdMSVBNEicKDGRpc3BsYXlfdHlwZRgNIAEoDjIRLkJhdHRsZVJlY29yZFR5",
            "cGUSIQoLS0pQTEFLTUtKTU4YCiABKAsyDC5MTUZQQkJHTkxJTxIhCgtMSk5C",
            "REpIRUhBShgLIAEoCzIMLkxBSU5BSUtMS0NCQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LMFPBBGNLIOReflection.Descriptor, global::EggLink.DanhengServer.Proto.LAINAIKLKCBReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleRecordTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.APOIBBGLIPM), global::EggLink.DanhengServer.Proto.APOIBBGLIPM.Parser, new[]{ "DisplayType", "KJPLAKMKJMN", "LJNBDJHEHAJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class APOIBBGLIPM : pb::IMessage<APOIBBGLIPM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<APOIBBGLIPM> _parser = new pb::MessageParser<APOIBBGLIPM>(() => new APOIBBGLIPM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<APOIBBGLIPM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.APOIBBGLIPMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APOIBBGLIPM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APOIBBGLIPM(APOIBBGLIPM other) : this() {
      displayType_ = other.displayType_;
      kJPLAKMKJMN_ = other.kJPLAKMKJMN_ != null ? other.kJPLAKMKJMN_.Clone() : null;
      lJNBDJHEHAJ_ = other.lJNBDJHEHAJ_ != null ? other.lJNBDJHEHAJ_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public APOIBBGLIPM Clone() {
      return new APOIBBGLIPM(this);
    }

    /// <summary>Field number for the "display_type" field.</summary>
    public const int DisplayTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.BattleRecordType displayType_ = global::EggLink.DanhengServer.Proto.BattleRecordType.BattleRecordNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleRecordType DisplayType {
      get { return displayType_; }
      set {
        displayType_ = value;
      }
    }

    /// <summary>Field number for the "KJPLAKMKJMN" field.</summary>
    public const int KJPLAKMKJMNFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.LMFPBBGNLIO kJPLAKMKJMN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LMFPBBGNLIO KJPLAKMKJMN {
      get { return kJPLAKMKJMN_; }
      set {
        kJPLAKMKJMN_ = value;
      }
    }

    /// <summary>Field number for the "LJNBDJHEHAJ" field.</summary>
    public const int LJNBDJHEHAJFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.LAINAIKLKCB lJNBDJHEHAJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LAINAIKLKCB LJNBDJHEHAJ {
      get { return lJNBDJHEHAJ_; }
      set {
        lJNBDJHEHAJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as APOIBBGLIPM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(APOIBBGLIPM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DisplayType != other.DisplayType) return false;
      if (!object.Equals(KJPLAKMKJMN, other.KJPLAKMKJMN)) return false;
      if (!object.Equals(LJNBDJHEHAJ, other.LJNBDJHEHAJ)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DisplayType != global::EggLink.DanhengServer.Proto.BattleRecordType.BattleRecordNone) hash ^= DisplayType.GetHashCode();
      if (kJPLAKMKJMN_ != null) hash ^= KJPLAKMKJMN.GetHashCode();
      if (lJNBDJHEHAJ_ != null) hash ^= LJNBDJHEHAJ.GetHashCode();
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
      if (kJPLAKMKJMN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(KJPLAKMKJMN);
      }
      if (lJNBDJHEHAJ_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(LJNBDJHEHAJ);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.BattleRecordType.BattleRecordNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) DisplayType);
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
      if (kJPLAKMKJMN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(KJPLAKMKJMN);
      }
      if (lJNBDJHEHAJ_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(LJNBDJHEHAJ);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.BattleRecordType.BattleRecordNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) DisplayType);
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
      if (DisplayType != global::EggLink.DanhengServer.Proto.BattleRecordType.BattleRecordNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DisplayType);
      }
      if (kJPLAKMKJMN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KJPLAKMKJMN);
      }
      if (lJNBDJHEHAJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LJNBDJHEHAJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(APOIBBGLIPM other) {
      if (other == null) {
        return;
      }
      if (other.DisplayType != global::EggLink.DanhengServer.Proto.BattleRecordType.BattleRecordNone) {
        DisplayType = other.DisplayType;
      }
      if (other.kJPLAKMKJMN_ != null) {
        if (kJPLAKMKJMN_ == null) {
          KJPLAKMKJMN = new global::EggLink.DanhengServer.Proto.LMFPBBGNLIO();
        }
        KJPLAKMKJMN.MergeFrom(other.KJPLAKMKJMN);
      }
      if (other.lJNBDJHEHAJ_ != null) {
        if (lJNBDJHEHAJ_ == null) {
          LJNBDJHEHAJ = new global::EggLink.DanhengServer.Proto.LAINAIKLKCB();
        }
        LJNBDJHEHAJ.MergeFrom(other.LJNBDJHEHAJ);
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
          case 82: {
            if (kJPLAKMKJMN_ == null) {
              KJPLAKMKJMN = new global::EggLink.DanhengServer.Proto.LMFPBBGNLIO();
            }
            input.ReadMessage(KJPLAKMKJMN);
            break;
          }
          case 90: {
            if (lJNBDJHEHAJ_ == null) {
              LJNBDJHEHAJ = new global::EggLink.DanhengServer.Proto.LAINAIKLKCB();
            }
            input.ReadMessage(LJNBDJHEHAJ);
            break;
          }
          case 104: {
            DisplayType = (global::EggLink.DanhengServer.Proto.BattleRecordType) input.ReadEnum();
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
          case 82: {
            if (kJPLAKMKJMN_ == null) {
              KJPLAKMKJMN = new global::EggLink.DanhengServer.Proto.LMFPBBGNLIO();
            }
            input.ReadMessage(KJPLAKMKJMN);
            break;
          }
          case 90: {
            if (lJNBDJHEHAJ_ == null) {
              LJNBDJHEHAJ = new global::EggLink.DanhengServer.Proto.LAINAIKLKCB();
            }
            input.ReadMessage(LJNBDJHEHAJ);
            break;
          }
          case 104: {
            DisplayType = (global::EggLink.DanhengServer.Proto.BattleRecordType) input.ReadEnum();
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