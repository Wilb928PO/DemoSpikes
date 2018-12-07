using Spikes.PriorityQueues.Helpers;
using Spikes.PriorityQueues.Interfaces;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Spikes.PriorityQueues.Implements
{
    public class PQByMeasure : IProcessQueues
    {
        private QueueManager queueManager;
        private ConcurrentDictionary<PriorityQueue, int> measure;
        private ConcurrentDictionary<PriorityQueue, int> decrement;
        private IEnumerable<PriorityQueue> iterator;
        private int lengthIterator;

        public PQByMeasure(ConcurrentDictionary<PriorityQueue, int> priorityMeasures, bool fromEnd = true)
        {
            queueManager = QueueManager.GetInstance();
            measure = priorityMeasures;
            iterator = PriorityQueueHelper.BuildIteratorPriorityQueue(fromEnd);
            lengthIterator = iterator.Count();
            decrement = new ConcurrentDictionary<PriorityQueue, int>();
            ResetDecrement();
        }

        private void ResetDecrement()
        {
            decrement.Clear();
            foreach (KeyValuePair<PriorityQueue, int> item in measure)
            {
                decrement.TryAdd(item.Key, item.Value);
            }
        }

        public ITestRequest GetRequest(bool delete = false)
        {
            ConcurrentQueue<ITestRequest> queue;
            PriorityQueue priority;            
            for (int i = 0; i < lengthIterator; i++)
            {
                priority = iterator.ElementAt(i);
                if (decrement[priority] > 0)
                {
                    if (!(queue = queueManager[priority]).IsEmpty)
                    {
                        ITestRequest outRequest;
                        if (delete)
                        {
                            queue.TryDequeue(out outRequest);
                            decrement[priority]--;
                            if (!decrement.Any(p => p.Value > 0))
                            {
                                ResetDecrement();
                            }
                        }
                        else queue.TryPeek(out outRequest);
                        return outRequest;
                    }
                    else if (i + 1 < lengthIterator)
                    {                        
                        decrement[iterator.ElementAt(i + 1)]++;
                        decrement[priority]--;
                    }
                }
            }
            return null;
        }
    }
}
