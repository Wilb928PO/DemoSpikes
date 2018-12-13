using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core
{
    public static class SharedHelper
    {
        public static bool IsFailed(this ITMTest test)
        {
            return test.NumberFailed > 0;
        }

        public static string ParallelizableString(this ITMTest test)
        {
            return test.Parallelizable? "Parallelizable": "NonParallelizable";
        }

        public static string ToStringFormat(this ITMTest test)
        {
            return $"{test.Name} : {test.NumberFailed} >> {test.ParallelizableString()} - RW({(test.ReadableWritable?"Yes":"No")}) | {test.Duration}";
        }
    }
}
