using Spikes.PriorityQueues.Helpers;
using Spikes.PriorityQueues.Interfaces;
using System.Collections.Concurrent;
using System.Linq;

namespace Spikes.PriorityQueues.Implements
{
    public class QueueManager : IQueueManager
    {
        private static QueueManager instance;

        public static QueueManager GetInstance()
        {
            if (instance==null) {
                instance = new QueueManager();
            }
            return instance;
        }

        private ConcurrentDictionary<PriorityQueue, ConcurrentQueue<ITestRequest>> queues;

        public IProcessQueues ProcessQueues { get; set; }

        private QueueManager()
        {
            queues = new ConcurrentDictionary<PriorityQueue, ConcurrentQueue<ITestRequest>>();
            var iterator = PriorityQueueHelper.BuildIteratorPriorityQueue();
            foreach (PriorityQueue priority in iterator)
            {
                queues.TryAdd(priority, new ConcurrentQueue<ITestRequest>());
            }
        }

        public ConcurrentQueue<ITestRequest> this[PriorityQueue key]
        {
            get
            {
                return queues[key];
            }
        }

        public bool HasRequest()
        {
            return queues.Any(q => q.Value.Any());
        }

        public int Count()
        {
            return queues.Count;
        }

        public void pushRequest(ITestRequest testRequest)
        {
            queues[testRequest.PriorityQueue].Enqueue(testRequest);
        }

        public ITestRequest popRequest()
        {
            return ProcessQueues.GetRequest(true);
        }
    }
}
