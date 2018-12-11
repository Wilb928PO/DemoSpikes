using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core
{
    public class TestQueueWrapper<T> where T : class
    {
        private SortedSet<T> tests;

        public TestQueueWrapper(IComparer<T> comparer, IEnumerable<T> collection = null)
        {
            tests = collection == null ? new SortedSet<T>(comparer)
                : new SortedSet<T>(collection, comparer);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool HasTest()
        {
            return tests.Count > 0;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool IsEmpty()
        {
            return tests.Count == 0;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public int Count()
        {
            return tests.Count;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool TryPush(T test)
        {
            return tests.Add(test);
        }
        
        protected T PeekMask()
        {
            return tests.Max;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Peek()
        {
            return PeekMask();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool TryPop(out T test)
        {
            test = PeekMask();
            return tests.Remove(test);
        }
    }
}
