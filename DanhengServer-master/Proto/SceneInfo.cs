// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneInfo.proto</summary>
  public static partial class SceneInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TY2VuZUluZm8ucHJvdG8aFVNjZW5lR3JvdXBTdGF0ZS5wcm90bxoURW50",
            "aXR5QnVmZkluZm8ucHJvdG8aFVNjZW5lRW50aXR5SW5mby5wcm90bxoeTWlz",
            "c2lvblN0YXR1c0J5U2NlbmVJbmZvLnByb3RvGhFETElCSkFGQkhFQS5wcm90",
            "bxoUQ3VzdG9tU2F2ZURhdGEucHJvdG8aDkJ1ZmZJbmZvLnByb3RvGhpTY2Vu",
            "ZUVudGl0eUdyb3VwSW5mby5wcm90byLGBgoJU2NlbmVJbmZvEhgKEGxlYWRl",
            "cl9lbnRpdHlfaWQYBSABKA0SMQoRZW50aXR5X2dyb3VwX2xpc3QYlQogAygL",
            "MhUuU2NlbmVFbnRpdHlHcm91cEluZm8SGgoSZ2FtZV9zdG9yeV9saW5lX2lk",
            "GBsgASgNEhAKCGVudHJ5X2lkGA4gASgNEi4KFWVudGl0eV9idWZmX2luZm9f",
            "bGlzdBgIIAMoCzIPLkVudGl0eUJ1ZmZJbmZvEiUKC2VudGl0eV9saXN0GAQg",
            "AygLMhAuU2NlbmVFbnRpdHlJbmZvEhAKCHdvcmxkX2lkGAsgASgNEhAKCHBs",
            "YW5lX2lkGAogASgNEikKEGN1c3RvbV9kYXRhX2xpc3QYDSADKAsyDy5DdXN0",
            "b21TYXZlRGF0YRInChRzY2VuZV9idWZmX2luZm9fbGlzdBgCIAMoCzIJLkJ1",
            "ZmZJbmZvEjYKEnNjZW5lX21pc3Npb25faW5mbxiPCCABKAsyGS5NaXNzaW9u",
            "U3RhdHVzQnlTY2VuZUluZm8SEwoKY29udGVudF9pZBjECiABKA0SFQoMZGlt",
            "ZW5zaW9uX2lkGOoIIAEoDRI5ChBmbG9vcl9zYXZlZF9kYXRhGKEKIAMoCzIe",
            "LlNjZW5lSW5mby5GbG9vclNhdmVkRGF0YUVudHJ5EhYKDmdhbWVfbW9kZV90",
            "eXBlGAkgASgNEjAKC0ZITEFNSUhPT0pBGA8gAygLMhsuU2NlbmVJbmZvLkZI",
            "TEFNSUhPT0pBRW50cnkSHAoUbGlnaHRlbl9zZWN0aW9uX2xpc3QYASADKA0S",
            "GgoSY2xpZW50X3Bvc192ZXJzaW9uGAYgASgNEhAKCGZsb29yX2lkGAcgASgN",
            "EisKEGdyb3VwX3N0YXRlX2xpc3QY6AsgAygLMhAuU2NlbmVHcm91cFN0YXRl",
            "EhQKC01HTEhFQkhKQUJFGKgIIAMoDRo1ChNGbG9vclNhdmVkRGF0YUVudHJ5",
            "EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoBToCOAEaQAoQRkhMQU1JSE9P",
            "SkFFbnRyeRILCgNrZXkYASABKA0SGwoFdmFsdWUYAiABKAsyDC5ETElCSkFG",
            "QkhFQToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneGroupStateReflection.Descriptor, global::EggLink.DanhengServer.Proto.EntityBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DLIBJAFBHEAReflection.Descriptor, global::EggLink.DanhengServer.Proto.CustomSaveDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.BuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneInfo), global::EggLink.DanhengServer.Proto.SceneInfo.Parser, new[]{ "LeaderEntityId", "EntityGroupList", "GameStoryLineId", "EntryId", "EntityBuffInfoList", "EntityList", "WorldId", "PlaneId", "CustomDataList", "SceneBuffInfoList", "SceneMissionInfo", "ContentId", "DimensionId", "FloorSavedData", "GameModeType", "FHLAMIHOOJA", "LightenSectionList", "ClientPosVersion", "FloorId", "GroupStateList", "MGLHEBHJABE" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneInfo : pb::IMessage<SceneInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneInfo> _parser = new pb::MessageParser<SceneInfo>(() => new SceneInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo(SceneInfo other) : this() {
      leaderEntityId_ = other.leaderEntityId_;
      entityGroupList_ = other.entityGroupList_.Clone();
      gameStoryLineId_ = other.gameStoryLineId_;
      entryId_ = other.entryId_;
      entityBuffInfoList_ = other.entityBuffInfoList_.Clone();
      entityList_ = other.entityList_.Clone();
      worldId_ = other.worldId_;
      planeId_ = other.planeId_;
      customDataList_ = other.customDataList_.Clone();
      sceneBuffInfoList_ = other.sceneBuffInfoList_.Clone();
      sceneMissionInfo_ = other.sceneMissionInfo_ != null ? other.sceneMissionInfo_.Clone() : null;
      contentId_ = other.contentId_;
      dimensionId_ = other.dimensionId_;
      floorSavedData_ = other.floorSavedData_.Clone();
      gameModeType_ = other.gameModeType_;
      fHLAMIHOOJA_ = other.fHLAMIHOOJA_.Clone();
      lightenSectionList_ = other.lightenSectionList_.Clone();
      clientPosVersion_ = other.clientPosVersion_;
      floorId_ = other.floorId_;
      groupStateList_ = other.groupStateList_.Clone();
      mGLHEBHJABE_ = other.mGLHEBHJABE_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo Clone() {
      return new SceneInfo(this);
    }

    /// <summary>Field number for the "leader_entity_id" field.</summary>
    public const int LeaderEntityIdFieldNumber = 5;
    private uint leaderEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeaderEntityId {
      get { return leaderEntityId_; }
      set {
        leaderEntityId_ = value;
      }
    }

    /// <summary>Field number for the "entity_group_list" field.</summary>
    public const int EntityGroupListFieldNumber = 1301;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> _repeated_entityGroupList_codec
        = pb::FieldCodec.ForMessage(10410, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> entityGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> EntityGroupList {
      get { return entityGroupList_; }
    }

    /// <summary>Field number for the "game_story_line_id" field.</summary>
    public const int GameStoryLineIdFieldNumber = 27;
    private uint gameStoryLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameStoryLineId {
      get { return gameStoryLineId_; }
      set {
        gameStoryLineId_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 14;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "entity_buff_info_list" field.</summary>
    public const int EntityBuffInfoListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EntityBuffInfo> _repeated_entityBuffInfoList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.EntityBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> entityBuffInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> EntityBuffInfoList {
      get { return entityBuffInfoList_; }
    }

    /// <summary>Field number for the "entity_list" field.</summary>
    public const int EntityListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityInfo> _repeated_entityList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.SceneEntityInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> entityList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> EntityList {
      get { return entityList_; }
    }

    /// <summary>Field number for the "world_id" field.</summary>
    public const int WorldIdFieldNumber = 11;
    private uint worldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldId {
      get { return worldId_; }
      set {
        worldId_ = value;
      }
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 10;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "custom_data_list" field.</summary>
    public const int CustomDataListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CustomSaveData> _repeated_customDataList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.CustomSaveData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> customDataList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> CustomDataList {
      get { return customDataList_; }
    }

    /// <summary>Field number for the "scene_buff_info_list" field.</summary>
    public const int SceneBuffInfoListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BuffInfo> _repeated_sceneBuffInfoList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.BuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> sceneBuffInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> SceneBuffInfoList {
      get { return sceneBuffInfoList_; }
    }

    /// <summary>Field number for the "scene_mission_info" field.</summary>
    public const int SceneMissionInfoFieldNumber = 1039;
    private global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo sceneMissionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo SceneMissionInfo {
      get { return sceneMissionInfo_; }
      set {
        sceneMissionInfo_ = value;
      }
    }

    /// <summary>Field number for the "content_id" field.</summary>
    public const int ContentIdFieldNumber = 1348;
    private uint contentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentId {
      get { return contentId_; }
      set {
        contentId_ = value;
      }
    }

    /// <summary>Field number for the "dimension_id" field.</summary>
    public const int DimensionIdFieldNumber = 1130;
    private uint dimensionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DimensionId {
      get { return dimensionId_; }
      set {
        dimensionId_ = value;
      }
    }

    /// <summary>Field number for the "floor_saved_data" field.</summary>
    public const int FloorSavedDataFieldNumber = 1313;
    private static readonly pbc::MapField<string, int>.Codec _map_floorSavedData_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 10506);
    private readonly pbc::MapField<string, int> floorSavedData_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> FloorSavedData {
      get { return floorSavedData_; }
    }

    /// <summary>Field number for the "game_mode_type" field.</summary>
    public const int GameModeTypeFieldNumber = 9;
    private uint gameModeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameModeType {
      get { return gameModeType_; }
      set {
        gameModeType_ = value;
      }
    }

    /// <summary>Field number for the "FHLAMIHOOJA" field.</summary>
    public const int FHLAMIHOOJAFieldNumber = 15;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DLIBJAFBHEA>.Codec _map_fHLAMIHOOJA_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DLIBJAFBHEA>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.DLIBJAFBHEA.Parser), 122);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DLIBJAFBHEA> fHLAMIHOOJA_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DLIBJAFBHEA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DLIBJAFBHEA> FHLAMIHOOJA {
      get { return fHLAMIHOOJA_; }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    /// <summary>Field number for the "client_pos_version" field.</summary>
    public const int ClientPosVersionFieldNumber = 6;
    private uint clientPosVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientPosVersion {
      get { return clientPosVersion_; }
      set {
        clientPosVersion_ = value;
      }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 7;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "group_state_list" field.</summary>
    public const int GroupStateListFieldNumber = 1512;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneGroupState> _repeated_groupStateList_codec
        = pb::FieldCodec.ForMessage(12098, global::EggLink.DanhengServer.Proto.SceneGroupState.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> groupStateList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> GroupStateList {
      get { return groupStateList_; }
    }

    /// <summary>Field number for the "MGLHEBHJABE" field.</summary>
    public const int MGLHEBHJABEFieldNumber = 1064;
    private static readonly pb::FieldCodec<uint> _repeated_mGLHEBHJABE_codec
        = pb::FieldCodec.ForUInt32(8514);
    private readonly pbc::RepeatedField<uint> mGLHEBHJABE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MGLHEBHJABE {
      get { return mGLHEBHJABE_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LeaderEntityId != other.LeaderEntityId) return false;
      if(!entityGroupList_.Equals(other.entityGroupList_)) return false;
      if (GameStoryLineId != other.GameStoryLineId) return false;
      if (EntryId != other.EntryId) return false;
      if(!entityBuffInfoList_.Equals(other.entityBuffInfoList_)) return false;
      if(!entityList_.Equals(other.entityList_)) return false;
      if (WorldId != other.WorldId) return false;
      if (PlaneId != other.PlaneId) return false;
      if(!customDataList_.Equals(other.customDataList_)) return false;
      if(!sceneBuffInfoList_.Equals(other.sceneBuffInfoList_)) return false;
      if (!object.Equals(SceneMissionInfo, other.SceneMissionInfo)) return false;
      if (ContentId != other.ContentId) return false;
      if (DimensionId != other.DimensionId) return false;
      if (!FloorSavedData.Equals(other.FloorSavedData)) return false;
      if (GameModeType != other.GameModeType) return false;
      if (!FHLAMIHOOJA.Equals(other.FHLAMIHOOJA)) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      if (ClientPosVersion != other.ClientPosVersion) return false;
      if (FloorId != other.FloorId) return false;
      if(!groupStateList_.Equals(other.groupStateList_)) return false;
      if(!mGLHEBHJABE_.Equals(other.mGLHEBHJABE_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LeaderEntityId != 0) hash ^= LeaderEntityId.GetHashCode();
      hash ^= entityGroupList_.GetHashCode();
      if (GameStoryLineId != 0) hash ^= GameStoryLineId.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      hash ^= entityBuffInfoList_.GetHashCode();
      hash ^= entityList_.GetHashCode();
      if (WorldId != 0) hash ^= WorldId.GetHashCode();
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      hash ^= customDataList_.GetHashCode();
      hash ^= sceneBuffInfoList_.GetHashCode();
      if (sceneMissionInfo_ != null) hash ^= SceneMissionInfo.GetHashCode();
      if (ContentId != 0) hash ^= ContentId.GetHashCode();
      if (DimensionId != 0) hash ^= DimensionId.GetHashCode();
      hash ^= FloorSavedData.GetHashCode();
      if (GameModeType != 0) hash ^= GameModeType.GetHashCode();
      hash ^= FHLAMIHOOJA.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
      if (ClientPosVersion != 0) hash ^= ClientPosVersion.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      hash ^= groupStateList_.GetHashCode();
      hash ^= mGLHEBHJABE_.GetHashCode();
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
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      sceneBuffInfoList_.WriteTo(output, _repeated_sceneBuffInfoList_codec);
      entityList_.WriteTo(output, _repeated_entityList_codec);
      if (LeaderEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeaderEntityId);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ClientPosVersion);
      }
      if (FloorId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FloorId);
      }
      entityBuffInfoList_.WriteTo(output, _repeated_entityBuffInfoList_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GameModeType);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PlaneId);
      }
      if (WorldId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldId);
      }
      customDataList_.WriteTo(output, _repeated_customDataList_codec);
      if (EntryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EntryId);
      }
      fHLAMIHOOJA_.WriteTo(output, _map_fHLAMIHOOJA_codec);
      if (GameStoryLineId != 0) {
        output.WriteRawTag(216, 1);
        output.WriteUInt32(GameStoryLineId);
      }
      if (sceneMissionInfo_ != null) {
        output.WriteRawTag(250, 64);
        output.WriteMessage(SceneMissionInfo);
      }
      mGLHEBHJABE_.WriteTo(output, _repeated_mGLHEBHJABE_codec);
      if (DimensionId != 0) {
        output.WriteRawTag(208, 70);
        output.WriteUInt32(DimensionId);
      }
      entityGroupList_.WriteTo(output, _repeated_entityGroupList_codec);
      floorSavedData_.WriteTo(output, _map_floorSavedData_codec);
      if (ContentId != 0) {
        output.WriteRawTag(160, 84);
        output.WriteUInt32(ContentId);
      }
      groupStateList_.WriteTo(output, _repeated_groupStateList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      sceneBuffInfoList_.WriteTo(ref output, _repeated_sceneBuffInfoList_codec);
      entityList_.WriteTo(ref output, _repeated_entityList_codec);
      if (LeaderEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LeaderEntityId);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ClientPosVersion);
      }
      if (FloorId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FloorId);
      }
      entityBuffInfoList_.WriteTo(ref output, _repeated_entityBuffInfoList_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GameModeType);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PlaneId);
      }
      if (WorldId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldId);
      }
      customDataList_.WriteTo(ref output, _repeated_customDataList_codec);
      if (EntryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(EntryId);
      }
      fHLAMIHOOJA_.WriteTo(ref output, _map_fHLAMIHOOJA_codec);
      if (GameStoryLineId != 0) {
        output.WriteRawTag(216, 1);
        output.WriteUInt32(GameStoryLineId);
      }
      if (sceneMissionInfo_ != null) {
        output.WriteRawTag(250, 64);
        output.WriteMessage(SceneMissionInfo);
      }
      mGLHEBHJABE_.WriteTo(ref output, _repeated_mGLHEBHJABE_codec);
      if (DimensionId != 0) {
        output.WriteRawTag(208, 70);
        output.WriteUInt32(DimensionId);
      }
      entityGroupList_.WriteTo(ref output, _repeated_entityGroupList_codec);
      floorSavedData_.WriteTo(ref output, _map_floorSavedData_codec);
      if (ContentId != 0) {
        output.WriteRawTag(160, 84);
        output.WriteUInt32(ContentId);
      }
      groupStateList_.WriteTo(ref output, _repeated_groupStateList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LeaderEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeaderEntityId);
      }
      size += entityGroupList_.CalculateSize(_repeated_entityGroupList_codec);
      if (GameStoryLineId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      size += entityBuffInfoList_.CalculateSize(_repeated_entityBuffInfoList_codec);
      size += entityList_.CalculateSize(_repeated_entityList_codec);
      if (WorldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldId);
      }
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      size += customDataList_.CalculateSize(_repeated_customDataList_codec);
      size += sceneBuffInfoList_.CalculateSize(_repeated_sceneBuffInfoList_codec);
      if (sceneMissionInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SceneMissionInfo);
      }
      if (ContentId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ContentId);
      }
      if (DimensionId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DimensionId);
      }
      size += floorSavedData_.CalculateSize(_map_floorSavedData_codec);
      if (GameModeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameModeType);
      }
      size += fHLAMIHOOJA_.CalculateSize(_map_fHLAMIHOOJA_codec);
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      if (ClientPosVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
      }
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      size += groupStateList_.CalculateSize(_repeated_groupStateList_codec);
      size += mGLHEBHJABE_.CalculateSize(_repeated_mGLHEBHJABE_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneInfo other) {
      if (other == null) {
        return;
      }
      if (other.LeaderEntityId != 0) {
        LeaderEntityId = other.LeaderEntityId;
      }
      entityGroupList_.Add(other.entityGroupList_);
      if (other.GameStoryLineId != 0) {
        GameStoryLineId = other.GameStoryLineId;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      entityBuffInfoList_.Add(other.entityBuffInfoList_);
      entityList_.Add(other.entityList_);
      if (other.WorldId != 0) {
        WorldId = other.WorldId;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      customDataList_.Add(other.customDataList_);
      sceneBuffInfoList_.Add(other.sceneBuffInfoList_);
      if (other.sceneMissionInfo_ != null) {
        if (sceneMissionInfo_ == null) {
          SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
        }
        SceneMissionInfo.MergeFrom(other.SceneMissionInfo);
      }
      if (other.ContentId != 0) {
        ContentId = other.ContentId;
      }
      if (other.DimensionId != 0) {
        DimensionId = other.DimensionId;
      }
      floorSavedData_.MergeFrom(other.floorSavedData_);
      if (other.GameModeType != 0) {
        GameModeType = other.GameModeType;
      }
      fHLAMIHOOJA_.MergeFrom(other.fHLAMIHOOJA_);
      lightenSectionList_.Add(other.lightenSectionList_);
      if (other.ClientPosVersion != 0) {
        ClientPosVersion = other.ClientPosVersion;
      }
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      groupStateList_.Add(other.groupStateList_);
      mGLHEBHJABE_.Add(other.mGLHEBHJABE_);
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
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 18: {
            sceneBuffInfoList_.AddEntriesFrom(input, _repeated_sceneBuffInfoList_codec);
            break;
          }
          case 34: {
            entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
            break;
          }
          case 40: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 56: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 66: {
            entityBuffInfoList_.AddEntriesFrom(input, _repeated_entityBuffInfoList_codec);
            break;
          }
          case 72: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 80: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 88: {
            WorldId = input.ReadUInt32();
            break;
          }
          case 106: {
            customDataList_.AddEntriesFrom(input, _repeated_customDataList_codec);
            break;
          }
          case 112: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 122: {
            fHLAMIHOOJA_.AddEntriesFrom(input, _map_fHLAMIHOOJA_codec);
            break;
          }
          case 216: {
            GameStoryLineId = input.ReadUInt32();
            break;
          }
          case 8314: {
            if (sceneMissionInfo_ == null) {
              SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(SceneMissionInfo);
            break;
          }
          case 8514:
          case 8512: {
            mGLHEBHJABE_.AddEntriesFrom(input, _repeated_mGLHEBHJABE_codec);
            break;
          }
          case 9040: {
            DimensionId = input.ReadUInt32();
            break;
          }
          case 10410: {
            entityGroupList_.AddEntriesFrom(input, _repeated_entityGroupList_codec);
            break;
          }
          case 10506: {
            floorSavedData_.AddEntriesFrom(input, _map_floorSavedData_codec);
            break;
          }
          case 10784: {
            ContentId = input.ReadUInt32();
            break;
          }
          case 12098: {
            groupStateList_.AddEntriesFrom(input, _repeated_groupStateList_codec);
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
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 18: {
            sceneBuffInfoList_.AddEntriesFrom(ref input, _repeated_sceneBuffInfoList_codec);
            break;
          }
          case 34: {
            entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
            break;
          }
          case 40: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 56: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 66: {
            entityBuffInfoList_.AddEntriesFrom(ref input, _repeated_entityBuffInfoList_codec);
            break;
          }
          case 72: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 80: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 88: {
            WorldId = input.ReadUInt32();
            break;
          }
          case 106: {
            customDataList_.AddEntriesFrom(ref input, _repeated_customDataList_codec);
            break;
          }
          case 112: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 122: {
            fHLAMIHOOJA_.AddEntriesFrom(ref input, _map_fHLAMIHOOJA_codec);
            break;
          }
          case 216: {
            GameStoryLineId = input.ReadUInt32();
            break;
          }
          case 8314: {
            if (sceneMissionInfo_ == null) {
              SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(SceneMissionInfo);
            break;
          }
          case 8514:
          case 8512: {
            mGLHEBHJABE_.AddEntriesFrom(ref input, _repeated_mGLHEBHJABE_codec);
            break;
          }
          case 9040: {
            DimensionId = input.ReadUInt32();
            break;
          }
          case 10410: {
            entityGroupList_.AddEntriesFrom(ref input, _repeated_entityGroupList_codec);
            break;
          }
          case 10506: {
            floorSavedData_.AddEntriesFrom(ref input, _map_floorSavedData_codec);
            break;
          }
          case 10784: {
            ContentId = input.ReadUInt32();
            break;
          }
          case 12098: {
            groupStateList_.AddEntriesFrom(ref input, _repeated_groupStateList_codec);
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
