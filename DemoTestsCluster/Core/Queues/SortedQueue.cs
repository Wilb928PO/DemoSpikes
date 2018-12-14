using System;
using System.Collections.Generic;
using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster.Core.Queues
{
    /// <summary>
    /// Represents a sorted queue structure
    /// </summary>
    /// <typeparam name="T">Specifies the value type of queue</typeparam>
    public sealed class SortedQueue<T> : ISortedQueue<T>
    {
        private LinkedList<T> values;

        public IComparer<T> Comparer { get; private set; }

        /// <summary>
        /// Creates a instance of the class
        /// </summary>
        /// <param name="comparer">It's comparison strategy</param>
        /// <param name="collection">collection of values</param>
        public SortedQueue(IComparer<T> comparer, IEnumerable<T> collection = null)
        {
            //Verify that instance is not null
            if (comparer == null) throw new ArgumentOutOfRangeException("comparer", comparer, "The value is null.");            

            Comparer = comparer;
            values = collection != null ? new LinkedList<T>(collection) : new LinkedList<T>();
        }

        /// <summary>
        /// Determines if the queue has values
        /// </summary>
        /// <returns>true if the queue has values</returns>
        public bool HasValues()
        {
            return values.Count > 0;
        }

        /// <summary>
        /// Determines if the queue is empty
        /// </summary>
        /// <returns>true if the queue is empty</returns>
        public bool IsEmpty()
        {
            return values.Count == 0;
        }

        /// <summary>
        /// Gets values count of the queue
        /// </summary>
        /// <returns>return the count of values in the queue</returns>
        public int Count()
        {
            return values.Count;
        }

        /// <summary>
        /// Adds a value in the queue
        /// </summary>
        /// <param name="value">The value to be added</param>
        public void Push(T value)
        {
            var node = new LinkedListNode<T>(value);
            var iterador = values.First;
            while (iterador != null)
            {
                if (Comparer.Compare(value, iterador.Value) > 0)
                {
                    values.AddBefore(iterador, node);
                    return;
                }
                iterador = iterador.Next;
            }
            values.AddLast(node);
        }

        /// <summary>
        /// Gets the first value of the queue
        /// </summary>
        /// <returns>the first value in the queue</returns>
        public T Peek()
        {
            return values.First.Value;
        }

        /// <summary>
        /// Gets and Removes the first value of the queue
        /// </summary>
        /// <returns>the first value in the queue</returns>
        public T Pop()
        {
            T value = Peek();
            values.RemoveFirst();
            return value;
        }
    }
}
