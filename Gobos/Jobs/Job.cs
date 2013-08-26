namespace Outbreak.Jobs
{
    public class Job
    {
        public int? TargetEntity { get; private set; }
        public JobPriority Priority { get; private set; }
        public JobType JobType { get; private set; }
    }
}
