// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMagicFinishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMagicFinishInfo.proto</summary>
  public static partial class RogueMagicFinishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMagicFinishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMagicFinishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZU1hZ2ljRmluaXNoSW5mby5wcm90bxoXUm9ndWVNYWdpY0N1cklu",
            "Zm8ucHJvdG8aEUdJTEROQkRLT0xELnByb3RvGhBMaW5ldXBJbmZvLnByb3Rv",
            "GhFMQUVFUExCTERDQy5wcm90byK2AQoUUm9ndWVNYWdpY0ZpbmlzaEluZm8S",
            "IQoLRU5GQkpCSFBHR04YBSABKAsyDC5HSUxETkJES09MRBImChFyb2d1ZV9s",
            "aW5ldXBfaW5mbxgCIAEoCzILLkxpbmV1cEluZm8SMAoUcm9ndWVfdG91cm5f",
            "Y3VyX2luZm8YDyABKAsyEi5Sb2d1ZU1hZ2ljQ3VySW5mbxIhCgtFRkNETUhI",
            "Q0VESBgHIAEoCzIMLkxBRUVQTEJMRENDQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueMagicCurInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GILDNBDKOLDReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LAEEPLBLDCCReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMagicFinishInfo), global::EggLink.DanhengServer.Proto.RogueMagicFinishInfo.Parser, new[]{ "ENFBJBHPGGN", "RogueLineupInfo", "RogueTournCurInfo", "EFCDMHHCEDH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMagicFinishInfo : pb::IMessage<RogueMagicFinishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMagicFinishInfo> _parser = new pb::MessageParser<RogueMagicFinishInfo>(() => new RogueMagicFinishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMagicFinishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMagicFinishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicFinishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicFinishInfo(RogueMagicFinishInfo other) : this() {
      eNFBJBHPGGN_ = other.eNFBJBHPGGN_ != null ? other.eNFBJBHPGGN_.Clone() : null;
      rogueLineupInfo_ = other.rogueLineupInfo_ != null ? other.rogueLineupInfo_.Clone() : null;
      rogueTournCurInfo_ = other.rogueTournCurInfo_ != null ? other.rogueTournCurInfo_.Clone() : null;
      eFCDMHHCEDH_ = other.eFCDMHHCEDH_ != null ? other.eFCDMHHCEDH_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMagicFinishInfo Clone() {
      return new RogueMagicFinishInfo(this);
    }

    /// <summary>Field number for the "ENFBJBHPGGN" field.</summary>
    public const int ENFBJBHPGGNFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.GILDNBDKOLD eNFBJBHPGGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GILDNBDKOLD ENFBJBHPGGN {
      get { return eNFBJBHPGGN_; }
      set {
        eNFBJBHPGGN_ = value;
      }
    }

    /// <summary>Field number for the "rogue_lineup_info" field.</summary>
    public const int RogueLineupInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.LineupInfo rogueLineupInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LineupInfo RogueLineupInfo {
      get { return rogueLineupInfo_; }
      set {
        rogueLineupInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_cur_info" field.</summary>
    public const int RogueTournCurInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueMagicCurInfo rogueTournCurInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMagicCurInfo RogueTournCurInfo {
      get { return rogueTournCurInfo_; }
      set {
        rogueTournCurInfo_ = value;
      }
    }

    /// <summary>Field number for the "EFCDMHHCEDH" field.</summary>
    public const int EFCDMHHCEDHFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.LAEEPLBLDCC eFCDMHHCEDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LAEEPLBLDCC EFCDMHHCEDH {
      get { return eFCDMHHCEDH_; }
      set {
        eFCDMHHCEDH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMagicFinishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMagicFinishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ENFBJBHPGGN, other.ENFBJBHPGGN)) return false;
      if (!object.Equals(RogueLineupInfo, other.RogueLineupInfo)) return false;
      if (!object.Equals(RogueTournCurInfo, other.RogueTournCurInfo)) return false;
      if (!object.Equals(EFCDMHHCEDH, other.EFCDMHHCEDH)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eNFBJBHPGGN_ != null) hash ^= ENFBJBHPGGN.GetHashCode();
      if (rogueLineupInfo_ != null) hash ^= RogueLineupInfo.GetHashCode();
      if (rogueTournCurInfo_ != null) hash ^= RogueTournCurInfo.GetHashCode();
      if (eFCDMHHCEDH_ != null) hash ^= EFCDMHHCEDH.GetHashCode();
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
      if (rogueLineupInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueLineupInfo);
      }
      if (eNFBJBHPGGN_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ENFBJBHPGGN);
      }
      if (eFCDMHHCEDH_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(EFCDMHHCEDH);
      }
      if (rogueTournCurInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueTournCurInfo);
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
      if (rogueLineupInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueLineupInfo);
      }
      if (eNFBJBHPGGN_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ENFBJBHPGGN);
      }
      if (eFCDMHHCEDH_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(EFCDMHHCEDH);
      }
      if (rogueTournCurInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueTournCurInfo);
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
      if (eNFBJBHPGGN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ENFBJBHPGGN);
      }
      if (rogueLineupInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueLineupInfo);
      }
      if (rogueTournCurInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournCurInfo);
      }
      if (eFCDMHHCEDH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFCDMHHCEDH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMagicFinishInfo other) {
      if (other == null) {
        return;
      }
      if (other.eNFBJBHPGGN_ != null) {
        if (eNFBJBHPGGN_ == null) {
          ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.GILDNBDKOLD();
        }
        ENFBJBHPGGN.MergeFrom(other.ENFBJBHPGGN);
      }
      if (other.rogueLineupInfo_ != null) {
        if (rogueLineupInfo_ == null) {
          RogueLineupInfo = new global::EggLink.DanhengServer.Proto.LineupInfo();
        }
        RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
      }
      if (other.rogueTournCurInfo_ != null) {
        if (rogueTournCurInfo_ == null) {
          RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurInfo();
        }
        RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
      }
      if (other.eFCDMHHCEDH_ != null) {
        if (eFCDMHHCEDH_ == null) {
          EFCDMHHCEDH = new global::EggLink.DanhengServer.Proto.LAEEPLBLDCC();
        }
        EFCDMHHCEDH.MergeFrom(other.EFCDMHHCEDH);
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
          case 18: {
            if (rogueLineupInfo_ == null) {
              RogueLineupInfo = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(RogueLineupInfo);
            break;
          }
          case 42: {
            if (eNFBJBHPGGN_ == null) {
              ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.GILDNBDKOLD();
            }
            input.ReadMessage(ENFBJBHPGGN);
            break;
          }
          case 58: {
            if (eFCDMHHCEDH_ == null) {
              EFCDMHHCEDH = new global::EggLink.DanhengServer.Proto.LAEEPLBLDCC();
            }
            input.ReadMessage(EFCDMHHCEDH);
            break;
          }
          case 122: {
            if (rogueTournCurInfo_ == null) {
              RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurInfo();
            }
            input.ReadMessage(RogueTournCurInfo);
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
          case 18: {
            if (rogueLineupInfo_ == null) {
              RogueLineupInfo = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(RogueLineupInfo);
            break;
          }
          case 42: {
            if (eNFBJBHPGGN_ == null) {
              ENFBJBHPGGN = new global::EggLink.DanhengServer.Proto.GILDNBDKOLD();
            }
            input.ReadMessage(ENFBJBHPGGN);
            break;
          }
          case 58: {
            if (eFCDMHHCEDH_ == null) {
              EFCDMHHCEDH = new global::EggLink.DanhengServer.Proto.LAEEPLBLDCC();
            }
            input.ReadMessage(EFCDMHHCEDH);
            break;
          }
          case 122: {
            if (rogueTournCurInfo_ == null) {
              RogueTournCurInfo = new global::EggLink.DanhengServer.Proto.RogueMagicCurInfo();
            }
            input.ReadMessage(RogueTournCurInfo);
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
