using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMate.ClusterTestManager.Core.Interfaces
{
    public interface ITMTest
    {
        string Name { get; set; }

        int Duration { get; set; }

        bool Parallelizable { get; set; }

        bool ReadableWritable { get; set; }

        short NumberFailed { get; set; }

        List<TestCategory> Categories { get; set; }
    }
}
