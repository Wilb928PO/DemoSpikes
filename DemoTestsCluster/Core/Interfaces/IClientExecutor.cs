using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMate.ClusterTestManager.Core.Interfaces
{

    public interface IClientExecutor
    {
        string Name { get; }

        string Hostname { get; }

        bool VirtualMachine { get; }

        short NumberParallelizableTests { get; }
    }
}
