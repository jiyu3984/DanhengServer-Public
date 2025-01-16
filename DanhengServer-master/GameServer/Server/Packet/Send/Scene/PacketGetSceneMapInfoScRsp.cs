﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Enums.Scene;
using EggLink.DanhengServer.GameServer.Game.Player;
using EggLink.DanhengServer.Kcp;
using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Util;

namespace EggLink.DanhengServer.GameServer.Server.Packet.Send.Scene;

public class PacketGetSceneMapInfoScRsp : BasePacket
{
    public PacketGetSceneMapInfoScRsp(GetSceneMapInfoCsReq req, PlayerInstance player) : base(
        CmdIds.GetSceneMapInfoScRsp)
    {
        var rsp = new GetSceneMapInfoScRsp
        {
            PNBFDKENOJP = req.PNBFDKENOJP
        };

        foreach (var floorId in req.FloorIdList)
        {
            var mazeMap = new SceneMapInfo
            {
                FloorId = floorId,
                EntryStoryLineId = (uint)(player.StoryLineManager?.StoryLineData.CurStoryLineId ?? 0)
                //DimensionId = (uint)(player.SceneInstance?.EntityLoader is StoryLineEntityLoader loader ? loader.DimensionId
                //    : 0)
            };
            var mapDatas = GameData.MapEntranceData.Values.Where(x => x.FloorID == floorId).ToList();

            if (mapDatas.Count == 0)
            {
                rsp.SceneMapInfo.Add(mazeMap);
                continue;
            }

            var mapData = mapDatas.RandomElement();
            GameData.GetFloorInfo(mapData.PlaneID, mapData.FloorID, out var floorInfo);
            if (floorInfo == null)
            {
                rsp.SceneMapInfo.Add(mazeMap);
                continue;
            }

            mazeMap.ChestList.Add(new ChestInfo
            {
                ExistNum = 1,
                ChestType = ChestType.MapInfoChestTypeNormal
            });

            mazeMap.ChestList.Add(new ChestInfo
            {
                ExistNum = 1,
                ChestType = ChestType.MapInfoChestTypePuzzle
            });

            mazeMap.ChestList.Add(new ChestInfo
            {
                ExistNum = 1,
                ChestType = ChestType.MapInfoChestTypeChallenge
            });

            foreach (var groupInfo in floorInfo.Groups.Values) // all the icons on the map
            {
                var mazeGroup = new MazeGroup
                {
                    GroupId = (uint)groupInfo.Id
                };
                mazeMap.MazeGroupList.Add(mazeGroup);
            }

            foreach (var teleport in floorInfo.CachedTeleports.Values)
                mazeMap.UnlockTeleportList.Add((uint)teleport.MappingInfoID);

            foreach (var prop in floorInfo.UnlockedCheckpoints)
            {
                var mazeProp = new MazePropState
                {
                    GroupId = (uint)prop.AnchorGroupID,
                    ConfigId = (uint)prop.ID,
                    State = (uint)PropStateEnum.CheckPointEnable
                };
                mazeMap.MazePropList.Add(mazeProp);
            }

            if (!ConfigManager.Config.ServerOption.AutoLightSection)
            {
                player.SceneData!.UnlockSectionIdList.TryGetValue(mapData.FloorID, out var sections);
                foreach (var section in sections ?? []) mazeMap.LightenSectionList.Add((uint)section);
            }
            else
            {
                for (uint i = 0; i < 100; i++)
                    mazeMap.LightenSectionList.Add(i);
            }

            rsp.SceneMapInfo.Add(mazeMap);
        }

        SetData(rsp);
    }
}