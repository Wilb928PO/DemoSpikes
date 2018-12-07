using Spikes.PriorityQueues.Interfaces;

namespace Spikes.PriorityQueues.Implements
{
    public class DefaultTestRequest : ITestRequest
    {
        public PriorityQueue PriorityQueue { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} >> Priority : {PriorityQueue.ToString()}";
        }
    }
}
