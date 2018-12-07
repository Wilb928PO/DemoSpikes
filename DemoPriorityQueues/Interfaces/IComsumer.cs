namespace Spikes.PriorityQueues.Interfaces
{
    interface IComsumer
    {
        string Name { get; set; }

        void TestProcess(IQueueManager queueManager);
    }
}
