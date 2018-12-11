using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core
{
    public class ClientExecutor : IClientExecutor
    {
        public string Name { get; set; }

        public string Hostname { get; set; }

        public bool VirtualMachine { get; set; }

        public short NumberParallelizableTests { get; set; }
    }
}
