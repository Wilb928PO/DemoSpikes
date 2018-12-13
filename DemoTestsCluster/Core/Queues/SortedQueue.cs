using System.Collections.Generic;

namespace TeamMate.AutomationCluster.Core.Queues
{
    /// <summary>
    /// Represents safe sorted queue structure
    /// </summary>
    /// <typeparam name="T">Specifies the element type of queue</typeparam>
    public sealed class SortedQueue<T> : SortedQueueBase<T> where T : class
    {
        /// <summary>
        /// Creates a instance of the class
        /// </summary>
        /// <param name="comparer">It's comparison strategy</param>
        /// <param name="collection">collection of values</param>
        public SortedQueue(IComparer<T> comparer, IEnumerable<T> collection = null)
            : base(comparer, collection)
        {
        }
    }
}