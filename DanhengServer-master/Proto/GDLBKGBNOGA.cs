// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GDLBKGBNOGA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GDLBKGBNOGA.proto</summary>
  public static partial class GDLBKGBNOGAReflection {

    #region Descriptor
    /// <summary>File descriptor for GDLBKGBNOGA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GDLBKGBNOGAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHRExCS0dCTk9HQS5wcm90bxofU3Ryb25nQ2hhbGxlbmdlQXZhdGFyRGF0",
            "YS5wcm90byKKAQoLR0RMQktHQk5PR0ESEAoIc3RhZ2VfaWQYBCABKA0SLwoL",
            "Rk5FTEJQRkZBTUgYCiABKAsyGi5TdHJvbmdDaGFsbGVuZ2VBdmF0YXJEYXRh",
            "EhEKCW1heF9zY29yZRgLIAEoDRIQCghwYW5lbF9pZBgMIAEoDRITCgtEUE9D",
            "T0ZJQkJLTxgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.StrongChallengeAvatarDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GDLBKGBNOGA), global::EggLink.DanhengServer.Proto.GDLBKGBNOGA.Parser, new[]{ "StageId", "FNELBPFFAMH", "MaxScore", "PanelId", "DPOCOFIBBKO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GDLBKGBNOGA : pb::IMessage<GDLBKGBNOGA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GDLBKGBNOGA> _parser = new pb::MessageParser<GDLBKGBNOGA>(() => new GDLBKGBNOGA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GDLBKGBNOGA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GDLBKGBNOGAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GDLBKGBNOGA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GDLBKGBNOGA(GDLBKGBNOGA other) : this() {
      stageId_ = other.stageId_;
      fNELBPFFAMH_ = other.fNELBPFFAMH_ != null ? other.fNELBPFFAMH_.Clone() : null;
      maxScore_ = other.maxScore_;
      panelId_ = other.panelId_;
      dPOCOFIBBKO_ = other.dPOCOFIBBKO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GDLBKGBNOGA Clone() {
      return new GDLBKGBNOGA(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 4;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "FNELBPFFAMH" field.</summary>
    public const int FNELBPFFAMHFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData fNELBPFFAMH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData FNELBPFFAMH {
      get { return fNELBPFFAMH_; }
      set {
        fNELBPFFAMH_ = value;
      }
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 11;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    /// <summary>Field number for the "panel_id" field.</summary>
    public const int PanelIdFieldNumber = 12;
    private uint panelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PanelId {
      get { return panelId_; }
      set {
        panelId_ = value;
      }
    }

    /// <summary>Field number for the "DPOCOFIBBKO" field.</summary>
    public const int DPOCOFIBBKOFieldNumber = 5;
    private uint dPOCOFIBBKO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DPOCOFIBBKO {
      get { return dPOCOFIBBKO_; }
      set {
        dPOCOFIBBKO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GDLBKGBNOGA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GDLBKGBNOGA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (!object.Equals(FNELBPFFAMH, other.FNELBPFFAMH)) return false;
      if (MaxScore != other.MaxScore) return false;
      if (PanelId != other.PanelId) return false;
      if (DPOCOFIBBKO != other.DPOCOFIBBKO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (fNELBPFFAMH_ != null) hash ^= FNELBPFFAMH.GetHashCode();
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
      if (PanelId != 0) hash ^= PanelId.GetHashCode();
      if (DPOCOFIBBKO != 0) hash ^= DPOCOFIBBKO.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StageId);
      }
      if (DPOCOFIBBKO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DPOCOFIBBKO);
      }
      if (fNELBPFFAMH_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(FNELBPFFAMH);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaxScore);
      }
      if (PanelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PanelId);
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
      if (StageId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StageId);
      }
      if (DPOCOFIBBKO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DPOCOFIBBKO);
      }
      if (fNELBPFFAMH_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(FNELBPFFAMH);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaxScore);
      }
      if (PanelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PanelId);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (fNELBPFFAMH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FNELBPFFAMH);
      }
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (PanelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PanelId);
      }
      if (DPOCOFIBBKO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DPOCOFIBBKO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GDLBKGBNOGA other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.fNELBPFFAMH_ != null) {
        if (fNELBPFFAMH_ == null) {
          FNELBPFFAMH = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
        }
        FNELBPFFAMH.MergeFrom(other.FNELBPFFAMH);
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
      }
      if (other.PanelId != 0) {
        PanelId = other.PanelId;
      }
      if (other.DPOCOFIBBKO != 0) {
        DPOCOFIBBKO = other.DPOCOFIBBKO;
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
          case 32: {
            StageId = input.ReadUInt32();
            break;
          }
          case 40: {
            DPOCOFIBBKO = input.ReadUInt32();
            break;
          }
          case 82: {
            if (fNELBPFFAMH_ == null) {
              FNELBPFFAMH = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
            }
            input.ReadMessage(FNELBPFFAMH);
            break;
          }
          case 88: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 96: {
            PanelId = input.ReadUInt32();
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
          case 32: {
            StageId = input.ReadUInt32();
            break;
          }
          case 40: {
            DPOCOFIBBKO = input.ReadUInt32();
            break;
          }
          case 82: {
            if (fNELBPFFAMH_ == null) {
              FNELBPFFAMH = new global::EggLink.DanhengServer.Proto.StrongChallengeAvatarData();
            }
            input.ReadMessage(FNELBPFFAMH);
            break;
          }
          case 88: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 96: {
            PanelId = input.ReadUInt32();
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
