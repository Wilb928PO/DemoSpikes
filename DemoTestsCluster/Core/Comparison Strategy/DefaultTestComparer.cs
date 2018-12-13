using System;
using System.Collections.Generic;
using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster.Core.ComparisonStrategy
{
    /// <summary>
    /// Represents default implementation to compare two instance of ITest
    /// </summary>
    public sealed class DefaultTestComparer : IComparer<ITest>
    {
        /// <summary>
        /// Calculates order value for an instance
        /// </summary>
        /// <param name="test">The test to calculate</param>
        /// <returns>returns the order value where it should be</returns>
        private int CalculateOrder(ITest test)
        {            
            return (test.IsFailed() ? 2000000 : 0) + (test.Parallelizable ? 0 : 1000000) + test.Duration;
        }

        /// <summary>
        /// Compares two ITest
        /// </summary>
        /// <param name="x">First Instance</param>
        /// <param name="y">Second  Instance</param>
        /// <returns>return the status of te comparison{-1,0,1}</returns>
        public int Compare(ITest x, ITest y)
        {
            //if ((status = x.IsFailed().CompareTo(y.IsFailed())) == 0
            //    && (status = x.Parallelizable.CompareTo(y.Parallelizable)) == 0)
            //{
            //    return x.Duration.CompareTo(y.Duration) * -1;
            //}
            //return status;
            //Fails - First
            //NonParalelizable - Second
            //More Duration - Third
            return CalculateOrder(x).CompareTo(CalculateOrder(y));
        }
    }
}
