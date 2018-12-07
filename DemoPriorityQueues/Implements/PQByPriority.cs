using Spikes.PriorityQueues.Helpers;
using Spikes.PriorityQueues.Interfaces;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Spikes.PriorityQueues.Implements
{
    public class PQByPriority : IProcessQueues
    {
        private QueueManager queueManager;
        private IEnumerable<PriorityQueue> iterator;

        public PQByPriority(bool fromEnd = true)
        {
            queueManager = QueueManager.GetInstance();
            iterator = PriorityQueueHelper.BuildIteratorPriorityQueue(fromEnd);
        }

        public ITestRequest GetRequest(bool delete = false)
        {
            ConcurrentQueue<ITestRequest> queue;
            foreach (PriorityQueue priority in iterator)
            {
                queue = queueManager[priority];
                if (!queue.IsEmpty)
                {
                    ITestRequest outRequest;
                    if (delete) queue.TryDequeue(out outRequest);
                    else queue.TryPeek(out outRequest);
                    return outRequest;
                }
            }
            return null;
        }
    }
}
