using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMate.AutomationCluster.Core.Interfaces
{
    /// <summary>
    /// Represents an interface sorted queue structure
    /// </summary>
    /// <typeparam name="T">Specifies the element type of queue</typeparam>
    public interface ISortedQueue<T>
    {
        /// <summary>
        /// Determines the sortering type
        /// </summary>
        IComparer<T> Comparer { get; }

        /// <summary>
        /// Determines if the queue has values
        /// </summary>
        /// <returns>true if the queue has values</returns>
        bool HasValues();

        /// <summary>
        /// Determines if the queue is empty
        /// </summary>
        /// <returns>true if the queue is empty</returns>
        bool IsEmpty();

        /// <summary>
        /// Gets values count of the queue
        /// </summary>
        /// <returns>return the count of values in the queue</returns>
        int Count();

        /// <summary>
        /// Adds a value in the queue
        /// </summary>
        /// <param name="value">The value to be added</param>
        void Push(T value);        

        /// <summary>
        /// Gets the first value of the queue
        /// </summary>
        /// <returns>the first value in the queue</returns>
        T Peek();

        /// <summary>
        /// Gets and Removes the first value of the queue
        /// </summary>
        /// <returns>the first value in the queue</returns>
        T Pop();
    }
}
