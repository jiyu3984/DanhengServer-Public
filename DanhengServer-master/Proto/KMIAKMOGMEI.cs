// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KMIAKMOGMEI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KMIAKMOGMEI.proto</summary>
  public static partial class KMIAKMOGMEIReflection {

    #region Descriptor
    /// <summary>File descriptor for KMIAKMOGMEI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KMIAKMOGMEIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLTUlBS01PR01FSS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIqMBCgtL",
            "TUlBS01PR01FSRITCgtQTUhQTExQTk9FQxgGIAEoDRIiCgtPTEhCSkhHSk5O",
            "TBgOIAEoCzINLkl0ZW1Db3N0RGF0YRITCgtBQ0RFQlBJR0xOQRgIIAEoCBIg",
            "Cgljb3N0X2RhdGEYByABKAsyDS5JdGVtQ29zdERhdGESDwoHYnVmZl9pZBgJ",
            "IAEoDRITCgtNSUdCQ0lLTkRGTBgCIAEoCEIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KMIAKMOGMEI), global::EggLink.DanhengServer.Proto.KMIAKMOGMEI.Parser, new[]{ "PMHPLLPNOEC", "OLHBJHGJNNL", "ACDEBPIGLNA", "CostData", "BuffId", "MIGBCIKNDFL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KMIAKMOGMEI : pb::IMessage<KMIAKMOGMEI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KMIAKMOGMEI> _parser = new pb::MessageParser<KMIAKMOGMEI>(() => new KMIAKMOGMEI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KMIAKMOGMEI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KMIAKMOGMEIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KMIAKMOGMEI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KMIAKMOGMEI(KMIAKMOGMEI other) : this() {
      pMHPLLPNOEC_ = other.pMHPLLPNOEC_;
      oLHBJHGJNNL_ = other.oLHBJHGJNNL_ != null ? other.oLHBJHGJNNL_.Clone() : null;
      aCDEBPIGLNA_ = other.aCDEBPIGLNA_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      buffId_ = other.buffId_;
      mIGBCIKNDFL_ = other.mIGBCIKNDFL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KMIAKMOGMEI Clone() {
      return new KMIAKMOGMEI(this);
    }

    /// <summary>Field number for the "PMHPLLPNOEC" field.</summary>
    public const int PMHPLLPNOECFieldNumber = 6;
    private uint pMHPLLPNOEC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PMHPLLPNOEC {
      get { return pMHPLLPNOEC_; }
      set {
        pMHPLLPNOEC_ = value;
      }
    }

    /// <summary>Field number for the "OLHBJHGJNNL" field.</summary>
    public const int OLHBJHGJNNLFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ItemCostData oLHBJHGJNNL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData OLHBJHGJNNL {
      get { return oLHBJHGJNNL_; }
      set {
        oLHBJHGJNNL_ = value;
      }
    }

    /// <summary>Field number for the "ACDEBPIGLNA" field.</summary>
    public const int ACDEBPIGLNAFieldNumber = 8;
    private bool aCDEBPIGLNA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ACDEBPIGLNA {
      get { return aCDEBPIGLNA_; }
      set {
        aCDEBPIGLNA_ = value;
      }
    }

    /// <summary>Field number for the "cost_data" field.</summary>
    public const int CostDataFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 9;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "MIGBCIKNDFL" field.</summary>
    public const int MIGBCIKNDFLFieldNumber = 2;
    private bool mIGBCIKNDFL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MIGBCIKNDFL {
      get { return mIGBCIKNDFL_; }
      set {
        mIGBCIKNDFL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KMIAKMOGMEI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KMIAKMOGMEI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PMHPLLPNOEC != other.PMHPLLPNOEC) return false;
      if (!object.Equals(OLHBJHGJNNL, other.OLHBJHGJNNL)) return false;
      if (ACDEBPIGLNA != other.ACDEBPIGLNA) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      if (BuffId != other.BuffId) return false;
      if (MIGBCIKNDFL != other.MIGBCIKNDFL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PMHPLLPNOEC != 0) hash ^= PMHPLLPNOEC.GetHashCode();
      if (oLHBJHGJNNL_ != null) hash ^= OLHBJHGJNNL.GetHashCode();
      if (ACDEBPIGLNA != false) hash ^= ACDEBPIGLNA.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (MIGBCIKNDFL != false) hash ^= MIGBCIKNDFL.GetHashCode();
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
      if (MIGBCIKNDFL != false) {
        output.WriteRawTag(16);
        output.WriteBool(MIGBCIKNDFL);
      }
      if (PMHPLLPNOEC != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PMHPLLPNOEC);
      }
      if (costData_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CostData);
      }
      if (ACDEBPIGLNA != false) {
        output.WriteRawTag(64);
        output.WriteBool(ACDEBPIGLNA);
      }
      if (BuffId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BuffId);
      }
      if (oLHBJHGJNNL_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OLHBJHGJNNL);
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
      if (MIGBCIKNDFL != false) {
        output.WriteRawTag(16);
        output.WriteBool(MIGBCIKNDFL);
      }
      if (PMHPLLPNOEC != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PMHPLLPNOEC);
      }
      if (costData_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CostData);
      }
      if (ACDEBPIGLNA != false) {
        output.WriteRawTag(64);
        output.WriteBool(ACDEBPIGLNA);
      }
      if (BuffId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BuffId);
      }
      if (oLHBJHGJNNL_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OLHBJHGJNNL);
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
      if (PMHPLLPNOEC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PMHPLLPNOEC);
      }
      if (oLHBJHGJNNL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OLHBJHGJNNL);
      }
      if (ACDEBPIGLNA != false) {
        size += 1 + 1;
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (MIGBCIKNDFL != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KMIAKMOGMEI other) {
      if (other == null) {
        return;
      }
      if (other.PMHPLLPNOEC != 0) {
        PMHPLLPNOEC = other.PMHPLLPNOEC;
      }
      if (other.oLHBJHGJNNL_ != null) {
        if (oLHBJHGJNNL_ == null) {
          OLHBJHGJNNL = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        OLHBJHGJNNL.MergeFrom(other.OLHBJHGJNNL);
      }
      if (other.ACDEBPIGLNA != false) {
        ACDEBPIGLNA = other.ACDEBPIGLNA;
      }
      if (other.costData_ != null) {
        if (costData_ == null) {
          CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        CostData.MergeFrom(other.CostData);
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.MIGBCIKNDFL != false) {
        MIGBCIKNDFL = other.MIGBCIKNDFL;
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
            MIGBCIKNDFL = input.ReadBool();
            break;
          }
          case 48: {
            PMHPLLPNOEC = input.ReadUInt32();
            break;
          }
          case 58: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 64: {
            ACDEBPIGLNA = input.ReadBool();
            break;
          }
          case 72: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 114: {
            if (oLHBJHGJNNL_ == null) {
              OLHBJHGJNNL = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(OLHBJHGJNNL);
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
            MIGBCIKNDFL = input.ReadBool();
            break;
          }
          case 48: {
            PMHPLLPNOEC = input.ReadUInt32();
            break;
          }
          case 58: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 64: {
            ACDEBPIGLNA = input.ReadBool();
            break;
          }
          case 72: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 114: {
            if (oLHBJHGJNNL_ == null) {
              OLHBJHGJNNL = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(OLHBJHGJNNL);
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