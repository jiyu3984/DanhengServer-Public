// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DrinkMakerChallengeCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DrinkMakerChallengeCsReq.proto</summary>
  public static partial class DrinkMakerChallengeCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DrinkMakerChallengeCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DrinkMakerChallengeCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ecmlua01ha2VyQ2hhbGxlbmdlQ3NSZXEucHJvdG8aEUhISUlOQkVQQ1BJ",
            "LnByb3RvIlMKGERyaW5rTWFrZXJDaGFsbGVuZ2VDc1JlcRIhCgtKQkhORkhP",
            "Q0ZGUBgPIAEoCzIMLkhISUlOQkVQQ1BJEhQKDGNoYWxsZW5nZV9pZBgCIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HHIINBEPCPIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DrinkMakerChallengeCsReq), global::EggLink.DanhengServer.Proto.DrinkMakerChallengeCsReq.Parser, new[]{ "JBHNFHOCFFP", "ChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DrinkMakerChallengeCsReq : pb::IMessage<DrinkMakerChallengeCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DrinkMakerChallengeCsReq> _parser = new pb::MessageParser<DrinkMakerChallengeCsReq>(() => new DrinkMakerChallengeCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DrinkMakerChallengeCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DrinkMakerChallengeCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrinkMakerChallengeCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrinkMakerChallengeCsReq(DrinkMakerChallengeCsReq other) : this() {
      jBHNFHOCFFP_ = other.jBHNFHOCFFP_ != null ? other.jBHNFHOCFFP_.Clone() : null;
      challengeId_ = other.challengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrinkMakerChallengeCsReq Clone() {
      return new DrinkMakerChallengeCsReq(this);
    }

    /// <summary>Field number for the "JBHNFHOCFFP" field.</summary>
    public const int JBHNFHOCFFPFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.HHIINBEPCPI jBHNFHOCFFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HHIINBEPCPI JBHNFHOCFFP {
      get { return jBHNFHOCFFP_; }
      set {
        jBHNFHOCFFP_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 2;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DrinkMakerChallengeCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DrinkMakerChallengeCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(JBHNFHOCFFP, other.JBHNFHOCFFP)) return false;
      if (ChallengeId != other.ChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (jBHNFHOCFFP_ != null) hash ^= JBHNFHOCFFP.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
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
      if (ChallengeId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChallengeId);
      }
      if (jBHNFHOCFFP_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(JBHNFHOCFFP);
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
      if (ChallengeId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChallengeId);
      }
      if (jBHNFHOCFFP_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(JBHNFHOCFFP);
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
      if (jBHNFHOCFFP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JBHNFHOCFFP);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DrinkMakerChallengeCsReq other) {
      if (other == null) {
        return;
      }
      if (other.jBHNFHOCFFP_ != null) {
        if (jBHNFHOCFFP_ == null) {
          JBHNFHOCFFP = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
        }
        JBHNFHOCFFP.MergeFrom(other.JBHNFHOCFFP);
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (jBHNFHOCFFP_ == null) {
              JBHNFHOCFFP = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
            }
            input.ReadMessage(JBHNFHOCFFP);
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (jBHNFHOCFFP_ == null) {
              JBHNFHOCFFP = new global::EggLink.DanhengServer.Proto.HHIINBEPCPI();
            }
            input.ReadMessage(JBHNFHOCFFP);
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