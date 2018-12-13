using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster.Core
{
    /// <summary>
    /// Represents a helper class to add extended methods
    /// </summary>
    public static class SharedHelper
    {
        /// <summary>
        /// Determines if an instance of ITest failed some time
        /// </summary>
        /// <param name="classType">The instance that can use the extended method</param>
        /// <returns>true if classType.NumberFailed > 0 otherwise false</returns>
        public static bool IsFailed(this ITest classType)
        {
            return classType.NumberFailed > 0;
        }

        /// <summary>
        /// Converts the parallelizable property to string
        /// </summary>
        /// <param name="classType">The instance that can use the extended method</param>
        /// <returns>"Parallelizable" if true otherwise "NonParallelizable"</returns>
        public static string ParallelizableString(this ITest classType)
        {
            return classType.Parallelizable ? "Parallelizable" : "NonParallelizable";
        }

        /// <summary>
        /// Converts to specific format string an instance of ITest
        /// </summary>
        /// <param name="classType">The instance that can use the extended method</param>
        /// <returns></returns>
        public static string ToStringFormat(this ITest classType)
        {
            return $"{classType.Name} : {classType.NumberFailed} >> {classType.ParallelizableString()} - RW({(classType.ReadableWritable ? "Yes" : "No")}) | {classType.Duration}";
        }
    }
}
