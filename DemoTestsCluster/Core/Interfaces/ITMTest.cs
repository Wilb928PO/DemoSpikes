using System.Collections.Generic;

namespace TeamMate.ClusterTestManager.Core.Interfaces
{
    public interface ITMTest
    {
        string Name { get; }

        int Duration { get; set; }

        bool Parallelizable { get; }

        bool ReadableWritable { get; }

        short NumberFailed { get; set; }

        //List<TestCategory> Categories { get; set; }
    }
}
