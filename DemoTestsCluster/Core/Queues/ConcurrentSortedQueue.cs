﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster.Core.Queues
{
    /// <summary>
    /// Represents safe sorted queue structure to be handled by threads
    /// </summary>
    /// <typeparam name="T">Specifies the element type of queue</typeparam>
    public sealed class ConcurrentSortedQueue<T> : ISortedQueue<T>
    {
        private SortedQueue<T> delegateQueue;

        public IComparer<T> Comparer
        {
            get
            {
                return delegateQueue.Comparer;
            }
        }

        /// <summary>
        /// Creates a instance of the class
        /// </summary>
        /// <param name="comparer">It's comparison strategy</param>
        /// <param name="collection">collection of values</param>
        public ConcurrentSortedQueue(IComparer<T> comparer, IEnumerable<T> collection = null)
        {
            delegateQueue = new SortedQueue<T>(comparer, collection);            
        }

        /// <summary>
        /// Determines if the queue has values with concurrency block
        /// </summary>
        /// <returns>true if the queue has values</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool HasValues()
        {
            return delegateQueue.HasValues();
        }

        /// <summary>
        /// Determines if the queue is empty with concurrency block
        /// </summary>
        /// <returns>true if the queue is empty</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool IsEmpty()
        {
            return delegateQueue.IsEmpty();
        }

        /// <summary>
        /// Gets values count of the queue with concurrency block
        /// </summary>
        /// <returns>return the count of values in the queue</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public int Count()
        {
            return delegateQueue.Count();
        }

        /// <summary>
        /// Adds a value in the queue with concurrency block
        /// </summary>
        /// <param name="value">The value to be added</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Push(T value)
        {
            delegateQueue.Push(value);
        }

        /// <summary>
        /// Gets the first value of the queue with concurrency block
        /// </summary>
        /// <returns>the first value in the queue</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Peek()
        {
            return delegateQueue.Peek();
        }

        /// <summary>
        /// Gets and Removes the first value of the queue with concurrency block
        /// </summary>
        /// <returns>the first value in the queue</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Pop()
        {
            return delegateQueue.Pop();
        }
    }
}
