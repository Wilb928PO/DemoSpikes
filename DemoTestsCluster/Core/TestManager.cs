using System.Collections.Generic;
using TeamMate.ClusterTestManager.Core.Interfaces;
//using System.Linq;

namespace TeamMate.ClusterTestManager.Core
{
    public abstract class TestManager
    {
        public int LimitNumerFailed { get; set; }

        public List<ExecutionUrl> ExecutionUrls { get; set; }

        public List<IClientExecutor> ClientExecutors { get; set; }

        public TestQueueWrapper<ITMTest> TestsQueueWrapper { get; set; }
    }
}
