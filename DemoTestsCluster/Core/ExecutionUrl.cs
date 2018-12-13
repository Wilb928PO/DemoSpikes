using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMate.AutomationCluster.Core
{
    /// <summary>
    /// Represents a domain where the tests will be executed
    /// </summary>
    public class ExecutionUrl
    {
        public string Link { get; private set; }

        public bool Parallelizable { get; private set; }
    }
}
