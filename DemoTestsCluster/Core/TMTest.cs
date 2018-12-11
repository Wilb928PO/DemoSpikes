using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager.Core
{
    public class TMTest : ITMTest
    {
        public string Name { get; set; }//

        public int Duration { get; set; }

        public bool Parallelizable { get; set; }//

        public bool ReadableWritable { get; set; }//

        public short NumberFailed { get; set; }

        public List<TestCategory> Categories { get; set; }//x
    }
}
