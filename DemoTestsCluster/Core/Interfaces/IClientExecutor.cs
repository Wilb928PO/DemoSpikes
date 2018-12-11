using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMate.ClusterTestManager.Core.Interfaces
{

    public interface IClientExecutor
    {
        string Name { get; set; }

        string Hostname { get; set; }

        bool VirtualMachine { get; set; }

        short NumberParallelizableTests { get; set; }
    }
}
