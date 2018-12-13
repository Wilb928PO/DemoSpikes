using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster.Core
{
    /// <summary>
    /// Represents a client that can run test
    /// </summary>
    public class ClientExecutor : IClientExecutor
    {
        public string Name { get; private set; }

        public string Hostname { get; private set; }

        public bool VirtualMachine { get; private set; }

        public short NumberParallelizableTests { get; private set; }
    }
}
