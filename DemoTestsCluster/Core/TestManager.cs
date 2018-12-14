using System;
using System.Collections.Generic;
using TeamMate.AutomationCluster.Core.Interfaces;
using TeamMate.AutomationCluster.Core.ComparisonStrategy;
using TeamMate.AutomationCluster.Core.Queues;

namespace TeamMate.AutomationCluster.Core
{
    /// <summary>
    /// Represents the manager all resources of the cluster 
    /// How for example : Execution Urls, Client Executors, Tests Queue
    /// </summary>
    public class TestManager
    {
        public int LimitNumerFailed { get; private set; }

        public List<ExecutionUrl> ExecutionUrls { get; private set; }

        public List<IClientExecutor> ClientExecutors { get; private set; }

        public ISortedQueue<ITest> Queue { get; private set; }

        /// <summary>
        /// Creates a instance of the class
        /// </summary>
        /// <param name="limitNumerFailed">The value can not be negative</param>
        /// <param name="comparer">It's comparison strategy, if the value=null then the constructor apply DefaultTestComparer by defect</param>
        public TestManager(int limitNumerFailed, bool multiThreads, IComparer<ITest> comparer = null)
        {            
            if (limitNumerFailed < 0) throw new ArgumentOutOfRangeException("limitNumerFailed", limitNumerFailed, "The value is negative.");
            if (comparer == null) comparer = new DefaultTestComparer();
            if (multiThreads) Queue = new ConcurrentSortedQueue<ITest>(comparer);
            else Queue = new SortedQueue<ITest>(comparer);

            LimitNumerFailed = limitNumerFailed;
            ExecutionUrls = new List<ExecutionUrl>();
            ClientExecutors = new List<IClientExecutor>();            
        }
    }
}
