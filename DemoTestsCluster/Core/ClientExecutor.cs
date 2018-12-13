using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core
{
    public class ClientExecutor : IClientExecutor
    {
        public string Name { get; private set; }

        public string Hostname { get; private set; }

        public bool VirtualMachine { get; private set; }

        public short NumberParallelizableTests { get; private set; }
    }
}
