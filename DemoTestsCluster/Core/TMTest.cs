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
        public string Name { get; private set; }

        public int Duration { get; set; }

        public bool Parallelizable { get; private set; }

        public bool ReadableWritable { get; private set; }

        public short NumberFailed { get; set; }

        public TMTest(string name, int duration, bool parallelizable, bool readableWritable, short numberFailed)
        {
            Name = name;
            Duration = duration;
            Parallelizable = parallelizable;
            ReadableWritable = readableWritable;
            NumberFailed = numberFailed;
        }

        public TMTest(string name, bool parallelizable, bool readableWritable)
            : this(name, 0, parallelizable, readableWritable, 0)
        {

        }

        public override bool Equals(object obj)
        {
            return obj != null && Name == ((TMTest)obj).Name;
        }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
