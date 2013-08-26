using System.Collections.Generic;
using Outbreak.Enums;
using Vortex.Interface;
using Vortex.Interface.EntityBase;
using Vortex.Interface.World.Chunks;
using Vortex.Interface.World.Entities;
using Vortex.Interface.World.Triggers;

namespace Outbreak.Server.World.Providers
{
    public class WorldGenerator: IChunkLoader, IEntityLoader, ITriggerLoader
    {
        private readonly int _key;
        private readonly IEngine _engine;
        private readonly short _depth;

        public WorldGenerator(int key, short depth, IServer engine)
        {
            _key = key;
            _engine = engine;
            _depth = depth;
            _depth = 2;
        }

        public void Dispose()
        {
        }

        private int GetChunkRandomKey(ChunkKey key)
        {
            return (_key*key.X) + key.Y;
        }

        public event ChunkCallback OnChunkLoad;
        public event ChunkCallback OnChunksGenerated;
        public event ChunkKeyCallback OnChunksUnavailable;
        public void LoadChunks(List<ChunkKey> chunkKeys)
        {
            foreach(var key in chunkKeys)
            {
                LoadChunk(key);
            }
        }

        private void LoadChunk(ChunkKey key)
        {
            var chunk = new BlockChunk(_engine, _depth);
            chunk.Key = key;
            //var random = new Random(GetChunkRandomKey(key));

            for (ushort x = 0; x<16; x++)
            {
                for (ushort y = 0; y<16; y++)
                {
                    for(ushort z=0; z<_depth; z++)
                    {
                        chunk.SetBlockType(x, y, z, (ushort)(z+1));
                    }
                }
            }
            OnChunksGenerated(new List<IChunk> {chunk});
        }

        public event EntityChunkKeyCallback OnEntityGenerated;
        public event EntityChunkKeyCallback OnEntityLoaded;
        public event EntitiesCallback OnEntityUpdated;
        public event EntityIdCallback OnEntityDeleted;
        public event ChunkKeyCallback OnEntitiesUnavailable;
        public void LoadEntities(ChunkKey area)
        {
            OnEntityGenerated(new List<Entity>(), area);
        }

        public void LoadEntities(List<ChunkKey> area)
        {
            foreach (var item in area)
                LoadEntities(item);
        }

        public event TriggerCallback OnTriggerGenerated;
        public event TriggerCallback OnTriggerLoaded;
        public event ChunkKeyCallback OnTriggersUnavailable;
        public void LoadTriggers(ChunkKey location)
        {
            OnTriggerGenerated(location, new List<ITrigger>());
        }
    }
}
