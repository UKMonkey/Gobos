using System.Collections.Generic;
using Vortex.Interface.EntityBase;

namespace Outbreak.Jobs
{
    public interface IJobQueue
    {
        IEnumerable<Job> Jobs { get; }

        void AddJob(Job job);
        Job GetNextJob(Entity forWhom);
    }
}
