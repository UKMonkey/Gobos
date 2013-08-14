﻿using System.Collections.Generic;
using Vortex.Interface.Net;

namespace Outbreak.Net.Messages
{
    public class ClientInteractWithEntityMessage : Message
    {
        public int EntityId { get; set; }

        protected override void DeserializeImpl(IIncomingMessageStream messageStream)
        {
            EntityId = messageStream.ReadEntityId();
        }

        protected override void SerializeImpl(IOutgoingMessageStream messageStream)
        {
            messageStream.WriteEntityId(EntityId);
        }

        public override IEnumerable<int> EntityIds()
        {
            return new List<int>{EntityId};
        }
    }
}
