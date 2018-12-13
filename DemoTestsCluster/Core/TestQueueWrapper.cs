using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core
{
    public class TestQueueWrapper<T> where T : class
    {
        private LinkedList<T> tests;

        public IComparer<T> Comparer { get; set; }

        public TestQueueWrapper(IComparer<T> comparer, IEnumerable<T> collection = null)
        {
            //This call is to verify that instance is not null
            comparer.ToString();

            Comparer = comparer;
            tests = collection != null ? new LinkedList<T>(collection) : new LinkedList<T>();
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
        public void Push(T test)
        {
            if (tests.Count > 0)
            {
                var iterador = tests.First;
                var node = new LinkedListNode<T>(test);
                do
                {
                    if (Comparer.Compare(test, iterador.Value) > 0)
                    {
                        tests.AddBefore(iterador, node);
                        return;
                    }
                    iterador = iterador.Next;
                } while (iterador != null);
                tests.AddLast(node);
            }
            else
            {
                tests.AddFirst(test);
            }
        }

        protected T PeekMask()
        {
            return tests.First.Value;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Peek()
        {
            return PeekMask();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Pop()
        {
            T test = PeekMask();
            tests.RemoveFirst();
            return test;
        }
    }
}
