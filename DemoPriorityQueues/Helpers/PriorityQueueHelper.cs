using Spikes.PriorityQueues.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Spikes.PriorityQueues.Helpers
{
    public static class PriorityQueueHelper
    {
        public static IEnumerable<PriorityQueue> BuildIteratorPriorityQueue(bool reverse = false)
        {
            var iterator = Enum.GetValues(typeof(PriorityQueue)).Cast<PriorityQueue>();
            return reverse ? iterator.Reverse() : iterator;
        }

        private static PriorityQueue CastPriority(int priority)
        {
            return (PriorityQueue)Enum.Parse(typeof(PriorityQueue), priority.ToString());
        }      
    }
}
