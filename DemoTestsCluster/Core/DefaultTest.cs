using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster.Core
{
    /// <summary>
    /// Represents a test that can be executed
    /// </summary>
    public class DefaultTest : ITest
    {
        public string Name { get; private set; }

        public int Duration { get; set; }

        public bool Parallelizable { get; private set; }

        public bool ReadableWritable { get; private set; }

        public short NumberFailed { get; set; }

        public DefaultTest(string name, int duration, bool parallelizable, bool readableWritable, short numberFailed)
        {
            Name = name;
            Duration = duration;
            Parallelizable = parallelizable;
            ReadableWritable = readableWritable;
            NumberFailed = numberFailed;
        }

        public DefaultTest(string name, bool parallelizable, bool readableWritable)
            : this(name, 0, parallelizable, readableWritable, 0)
        {

        }

        public override bool Equals(object obj)
        {
            return obj != null && Name == ((DefaultTest)obj).Name;
        }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
