﻿using System;
using System.Collections.Generic;
using Outbreak.Items;
using Outbreak.Items.ItemGenerators;
using Vortex.Interface;

namespace Outbreak.Server.World.Providers.Biome.Buildings.Rooms
{
    public class LivingroomGenerator : BasicGenerator
    {
        public LivingroomGenerator(ItemGeneratorDictionary generatorDict, IServer server) :
            base(0, 2, GetAllowedItems(), generatorDict, server)
        {
        }

        private static IEnumerable<ItemTypeEnum> GetAllowedItems()
        {
            return new List<ItemTypeEnum>
                       {
                           ItemTypeEnum.Shotgun,
                           ItemTypeEnum.Pistol
                       };
        }

        public override IEnumerable<EntitySpawnData> GenerateRoomClutter(RoomData room, Random randomiser)
        {
            return new List<EntitySpawnData>();
        }

        public override bool CanGenerateForRoom(RoomType type)
        {
            if (type == RoomType.LivingRoom)
                return true;
            return false;
        }
    }
}
