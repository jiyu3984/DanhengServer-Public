// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetBagScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetBagScRsp.proto</summary>
  public static partial class GetBagScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetBagScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetBagScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHZXRCYWdTY1JzcC5wcm90bxoPRXF1aXBtZW50LnByb3RvGhVXYWl0RGVs",
            "UmVzb3VyY2UucHJvdG8aFFR1cm5Gb29kU3dpdGNoLnByb3RvGg5NYXRlcmlh",
            "bC5wcm90bxoOUGlsZUl0ZW0ucHJvdG8aD01hdGVyaWFsMC5wcm90bxoLUmVs",
            "aWMucHJvdG8ivgMKC0dldEJhZ1NjUnNwEiEKDnBpbGVfaXRlbV9saXN0GA4g",
            "AygLMgkuUGlsZUl0ZW0SIgoOZXF1aXBtZW50X2xpc3QYAiADKAsyCi5FcXVp",
            "cG1lbnQSDwoHcmV0Y29kZRgJIAEoDRIfCgtCUExBRU5DT0pOThgLIAMoCzIK",
            "Lk1hdGVyaWFsMBIeCgtHQU1FQUxCS0FBRBgKIAMoCzIJLk1hdGVyaWFsEiAK",
            "DW1hdGVyaWFsX2xpc3QYBCADKAsyCS5NYXRlcmlhbBIaCgpyZWxpY19saXN0",
            "GAMgAygLMgYuUmVsaWMSHwoLTU9LQ0RNQ0FLTkwYDSADKAsyCi5NYXRlcmlh",
            "bDASEwoLRE9PQUtBQUlDRlAYCCADKA0SEwoLRkFDR0pEQUNIT00YBSABKA0S",
            "MAoWd2FpdF9kZWxfcmVzb3VyY2VfbGlzdBgPIAMoCzIQLldhaXREZWxSZXNv",
            "dXJjZRIbChN1bmxvY2tfZm9ybXVsYV9saXN0GAEgAygNEikKEHR1cm5fZm9v",
            "ZF9zd2l0Y2gYDCADKA4yDy5UdXJuRm9vZFN3aXRjaBITCgtKTERHTEpESEVD",
            "QhgGIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EquipmentReflection.Descriptor, global::EggLink.DanhengServer.Proto.WaitDelResourceReflection.Descriptor, global::EggLink.DanhengServer.Proto.TurnFoodSwitchReflection.Descriptor, global::EggLink.DanhengServer.Proto.MaterialReflection.Descriptor, global::EggLink.DanhengServer.Proto.PileItemReflection.Descriptor, global::EggLink.DanhengServer.Proto.Material0Reflection.Descriptor, global::EggLink.DanhengServer.Proto.RelicReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetBagScRsp), global::EggLink.DanhengServer.Proto.GetBagScRsp.Parser, new[]{ "PileItemList", "EquipmentList", "Retcode", "BPLAENCOJNN", "GAMEALBKAAD", "MaterialList", "RelicList", "MOKCDMCAKNL", "DOOAKAAICFP", "FACGJDACHOM", "WaitDelResourceList", "UnlockFormulaList", "TurnFoodSwitch", "JLDGLJDHECB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetBagScRsp : pb::IMessage<GetBagScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetBagScRsp> _parser = new pb::MessageParser<GetBagScRsp>(() => new GetBagScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetBagScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetBagScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBagScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBagScRsp(GetBagScRsp other) : this() {
      pileItemList_ = other.pileItemList_.Clone();
      equipmentList_ = other.equipmentList_.Clone();
      retcode_ = other.retcode_;
      bPLAENCOJNN_ = other.bPLAENCOJNN_.Clone();
      gAMEALBKAAD_ = other.gAMEALBKAAD_.Clone();
      materialList_ = other.materialList_.Clone();
      relicList_ = other.relicList_.Clone();
      mOKCDMCAKNL_ = other.mOKCDMCAKNL_.Clone();
      dOOAKAAICFP_ = other.dOOAKAAICFP_.Clone();
      fACGJDACHOM_ = other.fACGJDACHOM_;
      waitDelResourceList_ = other.waitDelResourceList_.Clone();
      unlockFormulaList_ = other.unlockFormulaList_.Clone();
      turnFoodSwitch_ = other.turnFoodSwitch_.Clone();
      jLDGLJDHECB_ = other.jLDGLJDHECB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBagScRsp Clone() {
      return new GetBagScRsp(this);
    }

    /// <summary>Field number for the "pile_item_list" field.</summary>
    public const int PileItemListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PileItem> _repeated_pileItemList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.PileItem.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PileItem> pileItemList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PileItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PileItem> PileItemList {
      get { return pileItemList_; }
    }

    /// <summary>Field number for the "equipment_list" field.</summary>
    public const int EquipmentListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Equipment> _repeated_equipmentList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.Equipment.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Equipment> equipmentList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Equipment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Equipment> EquipmentList {
      get { return equipmentList_; }
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

    /// <summary>Field number for the "BPLAENCOJNN" field.</summary>
    public const int BPLAENCOJNNFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Material0> _repeated_bPLAENCOJNN_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.Material0.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material0> bPLAENCOJNN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material0>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material0> BPLAENCOJNN {
      get { return bPLAENCOJNN_; }
    }

    /// <summary>Field number for the "GAMEALBKAAD" field.</summary>
    public const int GAMEALBKAADFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Material> _repeated_gAMEALBKAAD_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.Material.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material> gAMEALBKAAD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material> GAMEALBKAAD {
      get { return gAMEALBKAAD_; }
    }

    /// <summary>Field number for the "material_list" field.</summary>
    public const int MaterialListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Material> _repeated_materialList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.Material.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material> materialList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material> MaterialList {
      get { return materialList_; }
    }

    /// <summary>Field number for the "relic_list" field.</summary>
    public const int RelicListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Relic> _repeated_relicList_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.Relic.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Relic> relicList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Relic>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Relic> RelicList {
      get { return relicList_; }
    }

    /// <summary>Field number for the "MOKCDMCAKNL" field.</summary>
    public const int MOKCDMCAKNLFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Material0> _repeated_mOKCDMCAKNL_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.Material0.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material0> mOKCDMCAKNL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material0>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Material0> MOKCDMCAKNL {
      get { return mOKCDMCAKNL_; }
    }

    /// <summary>Field number for the "DOOAKAAICFP" field.</summary>
    public const int DOOAKAAICFPFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_dOOAKAAICFP_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> dOOAKAAICFP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DOOAKAAICFP {
      get { return dOOAKAAICFP_; }
    }

    /// <summary>Field number for the "FACGJDACHOM" field.</summary>
    public const int FACGJDACHOMFieldNumber = 5;
    private uint fACGJDACHOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FACGJDACHOM {
      get { return fACGJDACHOM_; }
      set {
        fACGJDACHOM_ = value;
      }
    }

    /// <summary>Field number for the "wait_del_resource_list" field.</summary>
    public const int WaitDelResourceListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.WaitDelResource> _repeated_waitDelResourceList_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.WaitDelResource.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.WaitDelResource> waitDelResourceList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.WaitDelResource>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.WaitDelResource> WaitDelResourceList {
      get { return waitDelResourceList_; }
    }

    /// <summary>Field number for the "unlock_formula_list" field.</summary>
    public const int UnlockFormulaListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_unlockFormulaList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> unlockFormulaList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockFormulaList {
      get { return unlockFormulaList_; }
    }

    /// <summary>Field number for the "turn_food_switch" field.</summary>
    public const int TurnFoodSwitchFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.TurnFoodSwitch> _repeated_turnFoodSwitch_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::EggLink.DanhengServer.Proto.TurnFoodSwitch) x);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TurnFoodSwitch> turnFoodSwitch_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TurnFoodSwitch>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.TurnFoodSwitch> TurnFoodSwitch {
      get { return turnFoodSwitch_; }
    }

    /// <summary>Field number for the "JLDGLJDHECB" field.</summary>
    public const int JLDGLJDHECBFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_jLDGLJDHECB_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> jLDGLJDHECB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JLDGLJDHECB {
      get { return jLDGLJDHECB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetBagScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetBagScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!pileItemList_.Equals(other.pileItemList_)) return false;
      if(!equipmentList_.Equals(other.equipmentList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!bPLAENCOJNN_.Equals(other.bPLAENCOJNN_)) return false;
      if(!gAMEALBKAAD_.Equals(other.gAMEALBKAAD_)) return false;
      if(!materialList_.Equals(other.materialList_)) return false;
      if(!relicList_.Equals(other.relicList_)) return false;
      if(!mOKCDMCAKNL_.Equals(other.mOKCDMCAKNL_)) return false;
      if(!dOOAKAAICFP_.Equals(other.dOOAKAAICFP_)) return false;
      if (FACGJDACHOM != other.FACGJDACHOM) return false;
      if(!waitDelResourceList_.Equals(other.waitDelResourceList_)) return false;
      if(!unlockFormulaList_.Equals(other.unlockFormulaList_)) return false;
      if(!turnFoodSwitch_.Equals(other.turnFoodSwitch_)) return false;
      if(!jLDGLJDHECB_.Equals(other.jLDGLJDHECB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= pileItemList_.GetHashCode();
      hash ^= equipmentList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= bPLAENCOJNN_.GetHashCode();
      hash ^= gAMEALBKAAD_.GetHashCode();
      hash ^= materialList_.GetHashCode();
      hash ^= relicList_.GetHashCode();
      hash ^= mOKCDMCAKNL_.GetHashCode();
      hash ^= dOOAKAAICFP_.GetHashCode();
      if (FACGJDACHOM != 0) hash ^= FACGJDACHOM.GetHashCode();
      hash ^= waitDelResourceList_.GetHashCode();
      hash ^= unlockFormulaList_.GetHashCode();
      hash ^= turnFoodSwitch_.GetHashCode();
      hash ^= jLDGLJDHECB_.GetHashCode();
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
      unlockFormulaList_.WriteTo(output, _repeated_unlockFormulaList_codec);
      equipmentList_.WriteTo(output, _repeated_equipmentList_codec);
      relicList_.WriteTo(output, _repeated_relicList_codec);
      materialList_.WriteTo(output, _repeated_materialList_codec);
      if (FACGJDACHOM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FACGJDACHOM);
      }
      jLDGLJDHECB_.WriteTo(output, _repeated_jLDGLJDHECB_codec);
      dOOAKAAICFP_.WriteTo(output, _repeated_dOOAKAAICFP_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      gAMEALBKAAD_.WriteTo(output, _repeated_gAMEALBKAAD_codec);
      bPLAENCOJNN_.WriteTo(output, _repeated_bPLAENCOJNN_codec);
      turnFoodSwitch_.WriteTo(output, _repeated_turnFoodSwitch_codec);
      mOKCDMCAKNL_.WriteTo(output, _repeated_mOKCDMCAKNL_codec);
      pileItemList_.WriteTo(output, _repeated_pileItemList_codec);
      waitDelResourceList_.WriteTo(output, _repeated_waitDelResourceList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unlockFormulaList_.WriteTo(ref output, _repeated_unlockFormulaList_codec);
      equipmentList_.WriteTo(ref output, _repeated_equipmentList_codec);
      relicList_.WriteTo(ref output, _repeated_relicList_codec);
      materialList_.WriteTo(ref output, _repeated_materialList_codec);
      if (FACGJDACHOM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FACGJDACHOM);
      }
      jLDGLJDHECB_.WriteTo(ref output, _repeated_jLDGLJDHECB_codec);
      dOOAKAAICFP_.WriteTo(ref output, _repeated_dOOAKAAICFP_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      gAMEALBKAAD_.WriteTo(ref output, _repeated_gAMEALBKAAD_codec);
      bPLAENCOJNN_.WriteTo(ref output, _repeated_bPLAENCOJNN_codec);
      turnFoodSwitch_.WriteTo(ref output, _repeated_turnFoodSwitch_codec);
      mOKCDMCAKNL_.WriteTo(ref output, _repeated_mOKCDMCAKNL_codec);
      pileItemList_.WriteTo(ref output, _repeated_pileItemList_codec);
      waitDelResourceList_.WriteTo(ref output, _repeated_waitDelResourceList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += pileItemList_.CalculateSize(_repeated_pileItemList_codec);
      size += equipmentList_.CalculateSize(_repeated_equipmentList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += bPLAENCOJNN_.CalculateSize(_repeated_bPLAENCOJNN_codec);
      size += gAMEALBKAAD_.CalculateSize(_repeated_gAMEALBKAAD_codec);
      size += materialList_.CalculateSize(_repeated_materialList_codec);
      size += relicList_.CalculateSize(_repeated_relicList_codec);
      size += mOKCDMCAKNL_.CalculateSize(_repeated_mOKCDMCAKNL_codec);
      size += dOOAKAAICFP_.CalculateSize(_repeated_dOOAKAAICFP_codec);
      if (FACGJDACHOM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FACGJDACHOM);
      }
      size += waitDelResourceList_.CalculateSize(_repeated_waitDelResourceList_codec);
      size += unlockFormulaList_.CalculateSize(_repeated_unlockFormulaList_codec);
      size += turnFoodSwitch_.CalculateSize(_repeated_turnFoodSwitch_codec);
      size += jLDGLJDHECB_.CalculateSize(_repeated_jLDGLJDHECB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetBagScRsp other) {
      if (other == null) {
        return;
      }
      pileItemList_.Add(other.pileItemList_);
      equipmentList_.Add(other.equipmentList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      bPLAENCOJNN_.Add(other.bPLAENCOJNN_);
      gAMEALBKAAD_.Add(other.gAMEALBKAAD_);
      materialList_.Add(other.materialList_);
      relicList_.Add(other.relicList_);
      mOKCDMCAKNL_.Add(other.mOKCDMCAKNL_);
      dOOAKAAICFP_.Add(other.dOOAKAAICFP_);
      if (other.FACGJDACHOM != 0) {
        FACGJDACHOM = other.FACGJDACHOM;
      }
      waitDelResourceList_.Add(other.waitDelResourceList_);
      unlockFormulaList_.Add(other.unlockFormulaList_);
      turnFoodSwitch_.Add(other.turnFoodSwitch_);
      jLDGLJDHECB_.Add(other.jLDGLJDHECB_);
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
          case 10:
          case 8: {
            unlockFormulaList_.AddEntriesFrom(input, _repeated_unlockFormulaList_codec);
            break;
          }
          case 18: {
            equipmentList_.AddEntriesFrom(input, _repeated_equipmentList_codec);
            break;
          }
          case 26: {
            relicList_.AddEntriesFrom(input, _repeated_relicList_codec);
            break;
          }
          case 34: {
            materialList_.AddEntriesFrom(input, _repeated_materialList_codec);
            break;
          }
          case 40: {
            FACGJDACHOM = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            jLDGLJDHECB_.AddEntriesFrom(input, _repeated_jLDGLJDHECB_codec);
            break;
          }
          case 66:
          case 64: {
            dOOAKAAICFP_.AddEntriesFrom(input, _repeated_dOOAKAAICFP_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            gAMEALBKAAD_.AddEntriesFrom(input, _repeated_gAMEALBKAAD_codec);
            break;
          }
          case 90: {
            bPLAENCOJNN_.AddEntriesFrom(input, _repeated_bPLAENCOJNN_codec);
            break;
          }
          case 98:
          case 96: {
            turnFoodSwitch_.AddEntriesFrom(input, _repeated_turnFoodSwitch_codec);
            break;
          }
          case 106: {
            mOKCDMCAKNL_.AddEntriesFrom(input, _repeated_mOKCDMCAKNL_codec);
            break;
          }
          case 114: {
            pileItemList_.AddEntriesFrom(input, _repeated_pileItemList_codec);
            break;
          }
          case 122: {
            waitDelResourceList_.AddEntriesFrom(input, _repeated_waitDelResourceList_codec);
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
          case 10:
          case 8: {
            unlockFormulaList_.AddEntriesFrom(ref input, _repeated_unlockFormulaList_codec);
            break;
          }
          case 18: {
            equipmentList_.AddEntriesFrom(ref input, _repeated_equipmentList_codec);
            break;
          }
          case 26: {
            relicList_.AddEntriesFrom(ref input, _repeated_relicList_codec);
            break;
          }
          case 34: {
            materialList_.AddEntriesFrom(ref input, _repeated_materialList_codec);
            break;
          }
          case 40: {
            FACGJDACHOM = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            jLDGLJDHECB_.AddEntriesFrom(ref input, _repeated_jLDGLJDHECB_codec);
            break;
          }
          case 66:
          case 64: {
            dOOAKAAICFP_.AddEntriesFrom(ref input, _repeated_dOOAKAAICFP_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            gAMEALBKAAD_.AddEntriesFrom(ref input, _repeated_gAMEALBKAAD_codec);
            break;
          }
          case 90: {
            bPLAENCOJNN_.AddEntriesFrom(ref input, _repeated_bPLAENCOJNN_codec);
            break;
          }
          case 98:
          case 96: {
            turnFoodSwitch_.AddEntriesFrom(ref input, _repeated_turnFoodSwitch_codec);
            break;
          }
          case 106: {
            mOKCDMCAKNL_.AddEntriesFrom(ref input, _repeated_mOKCDMCAKNL_codec);
            break;
          }
          case 114: {
            pileItemList_.AddEntriesFrom(ref input, _repeated_pileItemList_codec);
            break;
          }
          case 122: {
            waitDelResourceList_.AddEntriesFrom(ref input, _repeated_waitDelResourceList_codec);
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
